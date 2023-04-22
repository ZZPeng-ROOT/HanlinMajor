using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanlinMajor
{
    internal class utils
    {
        static public void killLinbo()
        {
            RunCmd("taskkill -f -im sbkup.exe");
            RunCmd("taskkill -f -im ncstu.exe");
        }

        public static string RunCmd(string cmd)
        {
            try
            {
                cmd = cmd.Trim().TrimEnd('&') + "&exit";//说明：不管命令是否成功均执行exit命令，否则当调用ReadToEnd()方法时，会处于假死状态
                using (Process p = new Process())
                {
                    p.StartInfo.FileName = "C:\\Windows\\System32\\cmd.exe";
                    p.StartInfo.UseShellExecute = false; //是否使用操作系统shell启动
                    p.StartInfo.RedirectStandardInput = true; //接受来自调用程序的输入信息
                    p.StartInfo.RedirectStandardOutput = true; //由调用程序获取输出信息
                    p.StartInfo.RedirectStandardError = true; //重定向标准错误输出
                    p.StartInfo.CreateNoWindow = true; //不显示程序窗口
                    p.Start();//启动程序

                    //向cmd窗口写入命令
                    p.StandardInput.WriteLine(cmd);
                    p.StandardInput.AutoFlush = true;

                    //获取cmd窗口的输出信息
                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();//等待程序执行完退出进程
                    p.Close();

                    return output;
                }
            }
            catch
            {
                return "ERROR";
            }
        }
        static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }

        public static bool manualUnzip()
        {
            try
            {
                System.Diagnostics.Process.Start(main.zipPath);
            }
            catch
            {
                return false;
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择解压后的hl.exe";
            dialog.Filter = "Half-Life.exe(hl.exe)|hl.exe";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                if (file == @"D:\Games\Counter-Strike\hl.exe")
                {
                    return true;
                }
                else
                {
                    CopyDirectory(Path.GetFullPath(file + "\\.."), @"D:\Games\Counter-Strike1\", true);
                    return true;
                }
            }
            return false;
        }
        
        public static void destroyLinbo()
        {
            while (File.Exists(@"C:\Program Files\lingbo\netclass7\NCStu.exe"))
            {
                try
                {
                    killLinbo();
                    DeleteFolder(@"C:\Program Files\lingbo");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return;
        }
        
        /// <summary>
        /// 递归删除文件夹目录及文件
        /// </summary>
        /// <param name="dir"></param>  
        /// <returns></returns>
        public static void DeleteFolder(string dir)
        {
            if (Directory.Exists(dir)) //如果存在这个文件夹删除之 
            {
                foreach (string d in Directory.GetFileSystemEntries(dir))
                {
                    if (File.Exists(d))
                        File.Delete(d); //直接删除其中的文件                        
                    else
                        DeleteFolder(d); //递归删除子文件夹 
                }
                Directory.Delete(dir, true); //删除已空文件夹                 
            }
        }

        public static string GetHash(string path)
        {
            //var hash = SHA256.Create();
            //var hash = MD5.Create();
            var hash = SHA1.Create();
            try
            {
                var stream = new FileStream(path, FileMode.Open);
                byte[] hashByte = hash.ComputeHash(stream);
                stream.Close();
                return BitConverter.ToString(hashByte).Replace("-", "");
            }
            catch (Exception)
            {
                //将path/filename复制到path/tmpfilename后尝试重新获取Hash值
                string[] tmp = path.Split('/', '\\');
                var fileName = tmp[tmp.Length - 1];
                File.Copy(fileName, "tmp" + fileName, true);
                path = path.Substring(0, path.Length - fileName.Length) + "tmp" + fileName;

                var stream = new FileStream(path, FileMode.Open);
                byte[] hashByte = hash.ComputeHash(stream);
                stream.Close();
                File.Delete(path);
                return BitConverter.ToString(hashByte).Replace("-", "");
            }
        }
    }
}
