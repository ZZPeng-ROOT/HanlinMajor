using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Xml.Linq;

namespace HanlinMajor
{
    public partial class main : MetroForm
    {
        
        public const string zipPath = @"D:\Counter-Strike.zip", directory = @"D:\Games";
        WebClient client;
        Thread downloadGameThread;
        Process CS_Server;
        ManualResetEvent wait= new ManualResetEvent(false);
        public main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public static (string, bool) Get(string Url, int retrytimes)
        {
            //忽略SSL证书问题
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
            string result = "";
            int retrys = 0;

        req:
            if (retrytimes == retrys)
            {
                return (result, false);
            }
            try
            {
                retrys++;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.Proxy = null;
                request.KeepAlive = false;
                request.Method = "GET";
                request.AutomaticDecompression = DecompressionMethods.GZip;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                result = myStreamReader.ReadToEnd();

                myStreamReader.Close();
                myResponseStream.Close();

                if (response != null)
                {
                    response.Close();
                }
                if (request != null)
                {
                    request.Abort();
                }
            }
            catch
            {
                Thread.Sleep(1000);
                goto req;
            }
            return (result, true);
        }

        public bool DownloadFile(string url, string path)
        {
            var (hash, success) = Get(url+".hash",1);
            if (!success)
            {
                return false;
            }
            try
            {
                Uri uri = new Uri(url);
                //string fileName = Path.GetFileName(uri.AbsolutePath);
                wait.Reset();
                client.DownloadFileAsync(uri, path);
                //using (var web = new WebClient())
                //{
                //    ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                //    web.DownloadFile(url, path);
                //}
                wait.WaitOne();
                
                if (hash != utils.GetHash(path))
                {
                    File.Delete(path);
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        private bool unzipGame()
        {
            downloadProgress.Value = 80;
            btn_Start.Text = "正在解压";
            try
            {
                ZipFile.ExtractToDirectory(zipPath, directory);
            }
            catch (Exception e)
            {
                var choose = MessageBox.Show("解压文件时出现问题:" + e.Message + "\n是否尝试手动解压?", 
                    "ERROR",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (choose == DialogResult.Yes)
                {
                    StartProgram(Process.GetCurrentProcess().MainModule.FileName,
                        "--choose-directory", Path.GetFullPath(Process.GetCurrentProcess().MainModule.FileName+"\\.."), false);
                }
                else
                {
                    File.Delete(zipPath);
                    btn_Start.Enabled = true;
                    btn_Start.Text = "重新下载";
                    return false;
                }
            }
            downloadProgress.Value = 100;
            btn_Start.Text = "进入游戏";
            if (label_playerInfo.Text != "需要登录")
            {
                btn_Start.Enabled = true;
            }
            return true;
        }

        private bool StartProgram(string path, string arg, string workspace, bool visualMode)
        {
            try
            {
                Process myprocess = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo(path);
                startInfo.Arguments = arg;
                startInfo.WorkingDirectory = workspace;
                myprocess.StartInfo = startInfo;
                myprocess.StartInfo.UseShellExecute = false;
                myprocess.Start();
                if (visualMode)
                {
                    btn_Start.Enabled = false;
                    btn_Start.Text = "正在游戏";
                }

                myprocess.WaitForExit();
                if (visualMode)
                {
                    btn_Start.Enabled = true;
                    btn_Start.Text = "进入游戏";
                }

                return true;
            }
            catch (Exception e0)
            {
                if (visualMode)
                {
                    MessageBox.Show("启动游戏失败:" + e0.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_Start.Enabled = true;
                    btn_Start.Text = "重新下载";
                }
                
                return false;
            }
        }
        private void downloadGame()
        {
            downloadProgress.Value = 0;
            btn_Start.Enabled = false;

            Directory.CreateDirectory(directory);
            if (File.Exists(directory + @"\Counter-Strike\hl.exe"))
            {
                downloadProgress.Value = 100;
                btn_Start.Text = "进入游戏";
                return;
            }
            if (File.Exists(zipPath))
            {
                var unzipSuccessfully = unzipGame();
                if (unzipSuccessfully)
                {
                    var message = new Form.Message("下载完成", "信息", 60, 100);
                    message.Show();
                    return;
                }
            }
            else

            {
                downloadProgress.Value = 0;
                if (DownloadFile(@"http://10.168.109.222:18666/Counter-Strike.zip", zipPath))
                {

                }
                //else if(DownloadFile(@"http://192.168.1.3/Counter-Strike.zip", zipPath))
                //{

                //}
                //else if (DownloadFile(@"https://hanlinmajor-1300078076.cos.ap-guangzhou.myqcloud.com/Counter-Strike.zip", zipPath))
                //{

                //}
                else if (!DownloadFile(@"http://hlmajor.zzpeng.com/Counter-Strike.zip", zipPath))
                {
                    File.Delete(zipPath);
                    MessageBox.Show("文件下载失败!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_Start.Enabled = true;
                    btn_Start.Text = "重新下载";
                    return;
                }
                var unzipSuccessfully = unzipGame();
                if (unzipSuccessfully)
                {
                    var message = new Form.Message("下载完成", "信息", 60, 100);
                    message.Show();
                    return;
                }
            }
            File.Delete(zipPath);
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            wait.Set();
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadProgress.Minimum = 0;
            double receive = double.Parse(e.BytesReceived.ToString());
            double total = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = receive / total * 100;
            btn_Start.Text = string.Format("下载中{0:0.##}", percentage) + "%";
            downloadProgress.Value = int.Parse(Math.Truncate(percentage * 0.8).ToString());

        }

        private void main_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("!测试版本!\n未完成功能:LinboKiller、Counter-Strike Server","WARNING");
            if(File.Exists(@"C:\Program Files\lingbo\netclass7\NCStu.exe"))
            {
                utils.destroyLinbo();
            }
            client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            downloadGameThread = new Thread(downloadGame);
            downloadGameThread.Start();

            //manualUnzip();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var name = textBox_ID.Text;
            if (name == string.Empty)
            {
                MessageBox.Show("用户名不能为空。", "非法用户名", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach(char c in name)
            {
                // 大小写英文数字下划线
                if (!(c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || c >= '0' && c <= 'z' || c == '_'))
                {
                    MessageBox.Show("用户名应由大小写英文，数字和下划线组成。", "非法用户名", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }



            //查询DB获取玩家信息
            if (true)
            {
                label_playerInfo.Text = "选手:"+name;
                lbl_Info.ForeColor = Color.Green;
                lbl_Info.Text = "准备就绪";
            }
            else
            {
                lbl_Info.Visible = false;
                label_Info.Visible = true;
                label_playerInfo.Visible = true; 
                label_TeamInfo.Visible = true;
                label_teammates1.Visible = true;
                label_teammates2.Visible = true;
                label_teammates3.Visible = true;
                label_teammates4.Visible = true;
                label_teammate.Visible = true;
                label_playerInfo.Text = "比赛未开始";
                label_TeamInfo.Text = "TEAM X - XX 无效队伍";
                label_teammates1.Text = "[无效队伍]";
                label_teammates2.Text = "[无效队伍]";
                label_teammates3.Text = "[无效队伍]";
                label_teammates4.Text = "[无效队伍]";
            }

            label_DAC_status.Text = "已激活 | 暂未发现作弊玩家";
            label_DAC_status.ForeColor = Color.Green;

            //FileStream fs = new FileStream(directory+ @"\Counter-Strike\cstrike\hlmajor.cfg", FileMode.Create, FileAccess.Read, FileShare.ReadWrite);
            //fs.Write(byte[]());
            Directory.CreateDirectory(@"D:\Games\Counter-Strike\cstrike\");
            File.WriteAllText(directory + @"\Counter-Strike\cstrike\hlmajor.cfg", "setinfo name " + name);

            if (downloadProgress.Value == 100){
                btn_Start.Enabled = true;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (btn_Start.Text == "重新下载")
            {
                Thread downloadGameThread = new Thread(downloadGame);
                downloadGameThread.Start();
            }
            else
            {
                //MessageBox.Show("!");
                //Process myprocess = new Process();
                //ProcessStartInfo startInfo = new ProcessStartInfo(@"D:\Games\Counter-Strike\hl.exe", @"-steam -game cstrike -noipx -nojoy -noforcemparms -noforcemaccel");
                //startInfo.WorkingDirectory = @"D:\Games\Counter-Strike";
                //myprocess.StartInfo = startInfo;
                //myprocess.StartInfo.UseShellExecute = false;
                //MessageBox.Show("!");
                StartProgram(@"D:\Games\Counter-Strike\Counter-Strike.bat", "", @"D:\Games\Counter-Strike", true);
            }
        }

        private void closeProcess(object sender, FormClosingEventArgs e)
        {
            downloadGameThread.Abort();
            client.CancelAsync();
        }
        private void btn_StartServer_Click(object sender, EventArgs e)
        {
            //检查输入
            foreach (char c in serverName.Text ){
                if (!(c >= 'A' && c <='Z' || c == ' ' || c == '_' || c >= 'a' && c <= 'z' || c >= '0' && c <= '9'))
                {
                    MessageBox.Show("服务器名称仅支持英文大小写，数字，下划线和空格", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            foreach (char c in maxPlayers.Text)
            {
                if (!(c >= '0' && c <= '9'))
                {
                    MessageBox.Show("最大玩家数应为整数", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (label_playerInfo.Text == "需要登录")
            {
                MessageBox.Show("请先登录。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (btn_StartServer.Text == "未运行")
            {
                if (btn_Start.Text != "进入游戏")
                {
                    MessageBox.Show("请等待游戏下载完成。", "服务器启动失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                serverSetup();
                CS_Server = new Process();
                try
                {
                    CS_Server.StartInfo.UseShellExecute = false;
                    CS_Server.StartInfo.FileName = @"D:\Games\Counter-Strike\hlds.exe";
                    CS_Server.StartInfo.Arguments = "-game cstrike -console -noipx +maxplayers " + maxPlayers.Text + " +map de_dust2 +mp_freezetime 15 +rcon_password HLMajor";
                    CS_Server.StartInfo.CreateNoWindow = true;
                    CS_Server.StartInfo.UseShellExecute = false;
                    CS_Server.StartInfo.WorkingDirectory= @"D:\Games\Counter-Strike\";
                    CS_Server.Exited += new EventHandler(CS_ServerExit);
                    CS_Server.Start();
                    serverName.Enabled = false;
                    maxPlayers.Enabled = false;
                    radioBtn_Competition.Enabled = false;
                    radioBtn_entertainment.Enabled = false;
                }
                catch (Exception ex)
                {
                    serverName.Enabled = true;
                    maxPlayers.Enabled = true;
                    radioBtn_Competition.Enabled = true;
                    radioBtn_entertainment.Enabled = true;
                    MessageBox.Show("运行CS服务器时出错:\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btn_StartServer.Text = "运行中";
            }
            else
            {
                if (!CS_Server.HasExited)
                {
                    CS_Server.Kill();
                }
                serverName.Enabled = true;
                maxPlayers.Enabled = true;
                radioBtn_Competition.Enabled = true;
                radioBtn_entertainment.Enabled = true;
                btn_StartServer.Text = "未运行";
            }
        }

        private void CS_ServerExit(object sender, EventArgs e)
        {
            btn_StartServer.Text = "未运行";
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void serverSetup()
        {
            Directory.CreateDirectory(@"D:\Games\Counter-Strike\cstrike\addons\amxmodx\configs\");
            StreamWriter sw = File.AppendText(@"D:\Games\Counter-Strike\cstrike\addons\amxmodx\configs\users.ini");

            sw.Write("\n\""+textBox_ID.Text+"\" \"\" \"abcdefghijklmnopqrst\" \"e\"");
            sw.Write("\n\"127.0.0.1\" \"\" \"abcdefghijklmnopqrst\" \"de\"");
            sw.Close();

            sw = File.AppendText(@"D:\Games\Counter-Strike\cstrike\server.cfg");
            sw.Write("\nhostname \""+serverName.Text+"\"");
            sw.Close();
            if (radioBtn_entertainment.Checked)
            {
                File.WriteAllText(@"D:\Games\Counter-Strike\cstrike\addons\amxmodx\configs\plugins.ini", @"; AMX Mod X plugins

; Admin Base - Always one has to be activated
admin.amxx		; admin base (required for any admin-related)
;admin_sql.amxx		; admin base - SQL version (comment admin.amxx)

; Basic
admincmd.amxx		; basic admin console commands
adminhelp.amxx		; help command for admin console commands
adminslots.amxx		; slot reservation
multilingual.amxx	; Multi-Lingual management

; Menus
menufront.amxx		; front-end for admin menus
cmdmenu.amxx		; command menu (speech, settings)
plmenu.amxx		; players menu (kick, ban, client cmds.)
;telemenu.amxx		; teleport menu (Fun Module required!)
mapsmenu.amxx		; maps menu (vote, changelevel)
pluginmenu.amxx		; Menus for commands/cvars organized by plugin

; Chat / Messages
adminchat.amxx		; console chat commands
antiflood.amxx		; prevent clients from chat-flooding the server
scrollmsg.amxx		; displays a scrolling message
imessage.amxx		; displays information messages
adminvote.amxx		; vote commands

; Map related
nextmap.amxx		; displays next map in mapcycle
mapchooser.amxx		; allows to vote for next map
timeleft.amxx		; displays time left on map

; Configuration
pausecfg.amxx		; allows to pause and unpause some plugins
statscfg.amxx		; allows to manage stats plugins via menu and commands

; Counter-Strike
;restmenu.amxx		; restrict weapons menu
statsx.amxx		; stats on death or round end (CSX Module required!)
;miscstats.amxx		; bunch of events announcement for Counter-Strike
;stats_logging.amxx	; weapons stats logging (CSX Module required!)

; Enable to use AMX Mod plugins
;amxmod_compat.amxx	; AMX Mod backwards compatibility layer

; Custom - Add 3rd party plugins here

; CMPS 比赛插件
;cmps_fix.amxx");
            }
            else
            {
                File.WriteAllText(@"D:\Games\Counter-Strike\cstrike\addons\amxmodx\configs\plugins.ini", @"; AMX Mod X plugins

; Admin Base - Always one has to be activated
admin.amxx		; admin base (required for any admin-related)
;admin_sql.amxx		; admin base - SQL version (comment admin.amxx)

; Basic
admincmd.amxx		; basic admin console commands
adminhelp.amxx		; help command for admin console commands
adminslots.amxx		; slot reservation
multilingual.amxx	; Multi-Lingual management

; Menus
menufront.amxx		; front-end for admin menus
cmdmenu.amxx		; command menu (speech, settings)
plmenu.amxx		; players menu (kick, ban, client cmds.)
;telemenu.amxx		; teleport menu (Fun Module required!)
mapsmenu.amxx		; maps menu (vote, changelevel)
pluginmenu.amxx		; Menus for commands/cvars organized by plugin

; Chat / Messages
adminchat.amxx		; console chat commands
antiflood.amxx		; prevent clients from chat-flooding the server
scrollmsg.amxx		; displays a scrolling message
imessage.amxx		; displays information messages
adminvote.amxx		; vote commands

; Map related
nextmap.amxx		; displays next map in mapcycle
mapchooser.amxx		; allows to vote for next map
timeleft.amxx		; displays time left on map

; Configuration
pausecfg.amxx		; allows to pause and unpause some plugins
statscfg.amxx		; allows to manage stats plugins via menu and commands

; Counter-Strike
;restmenu.amxx		; restrict weapons menu
statsx.amxx		; stats on death or round end (CSX Module required!)
;miscstats.amxx		; bunch of events announcement for Counter-Strike
;stats_logging.amxx	; weapons stats logging (CSX Module required!)

; Enable to use AMX Mod plugins
;amxmod_compat.amxx	; AMX Mod backwards compatibility layer

; Custom - Add 3rd party plugins here

; CMPS 比赛插件
cmps_fix.amxx");
            }
        }

        private void radioBtn_solo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_solo.Checked)
            {
                maxPlayers.Text= "2";
                maxPlayers.Enabled = false;
            }
            else
            {
                maxPlayers.Enabled = true;
            }
        }

        private void btn_more_Click(object sender, EventArgs e)
        {
            if (btn_more.Text == "<")
            {
                HL.Visible = false;
                btn_more.Text = ">";
            }
            else
            {
                HL.Visible = true;
                btn_more.Text = "<";
            }
            
        }
    }
}
