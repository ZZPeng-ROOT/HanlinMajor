namespace HanlinMajor
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.HL = new System.Windows.Forms.PictureBox();
            this.icon = new System.Windows.Forms.PictureBox();
            this.login_name = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label_playerInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.label_TeamInfo = new System.Windows.Forms.Label();
            this.label_Info = new System.Windows.Forms.Label();
            this.label_teammates4 = new System.Windows.Forms.Label();
            this.label_teammates3 = new System.Windows.Forms.Label();
            this.label_teammates2 = new System.Windows.Forms.Label();
            this.label_teammates1 = new System.Windows.Forms.Label();
            this.label_teammate = new System.Windows.Forms.Label();
            this.label_DAC_status = new System.Windows.Forms.Label();
            this.label_DAC = new System.Windows.Forms.Label();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_ServerStatusText = new System.Windows.Forms.Label();
            this.radioBtn_entertainment = new System.Windows.Forms.RadioButton();
            this.radioBtn_Competition = new System.Windows.Forms.RadioButton();
            this.btn_StartServer = new System.Windows.Forms.Button();
            this.btn_more = new System.Windows.Forms.Button();
            this.lbl_serverName = new System.Windows.Forms.Label();
            this.serverName = new System.Windows.Forms.TextBox();
            this.cs_server_ctrl = new System.Windows.Forms.GroupBox();
            this.lbl_maxplayers = new System.Windows.Forms.Label();
            this.maxPlayers = new System.Windows.Forms.ComboBox();
            this.radioBtn_solo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.HL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.cs_server_ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // HL
            // 
            this.HL.Image = ((System.Drawing.Image)(resources.GetObject("HL.Image")));
            this.HL.Location = new System.Drawing.Point(13, 79);
            this.HL.Name = "HL";
            this.HL.Size = new System.Drawing.Size(265, 348);
            this.HL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HL.TabIndex = 0;
            this.HL.TabStop = false;
            this.HL.Visible = false;
            // 
            // icon
            // 
            this.icon.Image = global::HanlinMajor.Properties.Resources.icon;
            this.icon.Location = new System.Drawing.Point(639, 42);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(150, 150);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // login_name
            // 
            this.login_name.AutoSize = true;
            this.login_name.Font = new System.Drawing.Font("宋体", 12F);
            this.login_name.Location = new System.Drawing.Point(294, 99);
            this.login_name.Name = "login_name";
            this.login_name.Size = new System.Drawing.Size(94, 24);
            this.login_name.TabIndex = 3;
            this.login_name.Text = "玩家ID:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(394, 95);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(147, 28);
            this.textBox_ID.TabIndex = 4;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_Login.Location = new System.Drawing.Point(543, 92);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(82, 38);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(292, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(263, 40);
            this.title.TabIndex = 2;
            this.title.Text = "玩家统一登录";
            // 
            // label_playerInfo
            // 
            this.label_playerInfo.Font = new System.Drawing.Font("宋体", 16F);
            this.label_playerInfo.Location = new System.Drawing.Point(301, 141);
            this.label_playerInfo.Name = "label_playerInfo";
            this.label_playerInfo.Size = new System.Drawing.Size(324, 33);
            this.label_playerInfo.TabIndex = 6;
            this.label_playerInfo.Text = "需要登录";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Info);
            this.panel1.Controls.Add(this.label_TeamInfo);
            this.panel1.Controls.Add(this.label_Info);
            this.panel1.Controls.Add(this.label_teammates4);
            this.panel1.Controls.Add(this.label_teammates3);
            this.panel1.Controls.Add(this.label_teammates2);
            this.panel1.Controls.Add(this.label_teammates1);
            this.panel1.Controls.Add(this.label_teammate);
            this.panel1.Controls.Add(this.label_DAC_status);
            this.panel1.Controls.Add(this.label_DAC);
            this.panel1.Location = new System.Drawing.Point(298, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 199);
            this.panel1.TabIndex = 7;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("宋体", 28F);
            this.lbl_Info.ForeColor = System.Drawing.Color.Red;
            this.lbl_Info.Location = new System.Drawing.Point(108, 68);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(248, 56);
            this.lbl_Info.TabIndex = 9;
            this.lbl_Info.Text = "请先登录";
            // 
            // label_TeamInfo
            // 
            this.label_TeamInfo.AutoSize = true;
            this.label_TeamInfo.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold);
            this.label_TeamInfo.Location = new System.Drawing.Point(1, 39);
            this.label_TeamInfo.Name = "label_TeamInfo";
            this.label_TeamInfo.Size = new System.Drawing.Size(475, 44);
            this.label_TeamInfo.TabIndex = 8;
            this.label_TeamInfo.Text = "Team X - XX 请先登录";
            this.label_TeamInfo.Visible = false;
            // 
            // label_Info
            // 
            this.label_Info.Font = new System.Drawing.Font("宋体", 12F);
            this.label_Info.Location = new System.Drawing.Point(7, 11);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(118, 24);
            this.label_Info.TabIndex = 7;
            this.label_Info.Text = "您的队伍:";
            this.label_Info.Visible = false;
            // 
            // label_teammates4
            // 
            this.label_teammates4.AutoSize = true;
            this.label_teammates4.Font = new System.Drawing.Font("宋体", 12F);
            this.label_teammates4.Location = new System.Drawing.Point(364, 129);
            this.label_teammates4.Name = "label_teammates4";
            this.label_teammates4.Size = new System.Drawing.Size(130, 24);
            this.label_teammates4.TabIndex = 6;
            this.label_teammates4.Text = "[请先登录]";
            this.label_teammates4.Visible = false;
            // 
            // label_teammates3
            // 
            this.label_teammates3.AutoSize = true;
            this.label_teammates3.Font = new System.Drawing.Font("宋体", 12F);
            this.label_teammates3.Location = new System.Drawing.Point(244, 129);
            this.label_teammates3.Name = "label_teammates3";
            this.label_teammates3.Size = new System.Drawing.Size(130, 24);
            this.label_teammates3.TabIndex = 5;
            this.label_teammates3.Text = "[请先登录]";
            this.label_teammates3.Visible = false;
            // 
            // label_teammates2
            // 
            this.label_teammates2.AutoSize = true;
            this.label_teammates2.Font = new System.Drawing.Font("宋体", 12F);
            this.label_teammates2.Location = new System.Drawing.Point(123, 129);
            this.label_teammates2.Name = "label_teammates2";
            this.label_teammates2.Size = new System.Drawing.Size(130, 24);
            this.label_teammates2.TabIndex = 4;
            this.label_teammates2.Text = "[请先登录]";
            this.label_teammates2.Visible = false;
            // 
            // label_teammates1
            // 
            this.label_teammates1.AutoSize = true;
            this.label_teammates1.Font = new System.Drawing.Font("宋体", 12F);
            this.label_teammates1.Location = new System.Drawing.Point(0, 129);
            this.label_teammates1.Name = "label_teammates1";
            this.label_teammates1.Size = new System.Drawing.Size(130, 24);
            this.label_teammates1.TabIndex = 3;
            this.label_teammates1.Text = "[请先登录]";
            this.label_teammates1.Visible = false;
            // 
            // label_teammate
            // 
            this.label_teammate.AutoSize = true;
            this.label_teammate.Font = new System.Drawing.Font("宋体", 12F);
            this.label_teammate.Location = new System.Drawing.Point(6, 95);
            this.label_teammate.Name = "label_teammate";
            this.label_teammate.Size = new System.Drawing.Size(118, 24);
            this.label_teammate.TabIndex = 2;
            this.label_teammate.Text = "您的队友:";
            this.label_teammate.Visible = false;
            // 
            // label_DAC_status
            // 
            this.label_DAC_status.AutoSize = true;
            this.label_DAC_status.Font = new System.Drawing.Font("宋体", 12F);
            this.label_DAC_status.ForeColor = System.Drawing.Color.Red;
            this.label_DAC_status.Location = new System.Drawing.Point(187, 175);
            this.label_DAC_status.Name = "label_DAC_status";
            this.label_DAC_status.Size = new System.Drawing.Size(310, 24);
            this.label_DAC_status.TabIndex = 1;
            this.label_DAC_status.Text = "未激活 | 正在连接至服务器";
            // 
            // label_DAC
            // 
            this.label_DAC.AllowDrop = true;
            this.label_DAC.AutoSize = true;
            this.label_DAC.Font = new System.Drawing.Font("宋体", 12F);
            this.label_DAC.Location = new System.Drawing.Point(3, 175);
            this.label_DAC.Name = "label_DAC";
            this.label_DAC.Size = new System.Drawing.Size(178, 24);
            this.label_DAC.TabIndex = 0;
            this.label_DAC.Text = "DAC反作弊状态:";
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(298, 390);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(327, 37);
            this.downloadProgress.TabIndex = 8;
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("宋体", 11F);
            this.btn_Start.Location = new System.Drawing.Point(631, 387);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(164, 40);
            this.btn_Start.TabIndex = 10;
            this.btn_Start.Text = "正在下载";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_ServerStatusText
            // 
            this.lbl_ServerStatusText.AutoSize = true;
            this.lbl_ServerStatusText.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_ServerStatusText.Location = new System.Drawing.Point(8, 262);
            this.lbl_ServerStatusText.Name = "lbl_ServerStatusText";
            this.lbl_ServerStatusText.Size = new System.Drawing.Size(119, 20);
            this.lbl_ServerStatusText.TabIndex = 3;
            this.lbl_ServerStatusText.Text = "本地服务器:";
            // 
            // radioBtn_entertainment
            // 
            this.radioBtn_entertainment.AutoSize = true;
            this.radioBtn_entertainment.Checked = true;
            this.radioBtn_entertainment.Font = new System.Drawing.Font("宋体", 9F);
            this.radioBtn_entertainment.Location = new System.Drawing.Point(12, 209);
            this.radioBtn_entertainment.Name = "radioBtn_entertainment";
            this.radioBtn_entertainment.Size = new System.Drawing.Size(105, 22);
            this.radioBtn_entertainment.TabIndex = 2;
            this.radioBtn_entertainment.Text = "娱乐模式";
            this.radioBtn_entertainment.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Competition
            // 
            this.radioBtn_Competition.AutoSize = true;
            this.radioBtn_Competition.Font = new System.Drawing.Font("宋体", 9F);
            this.radioBtn_Competition.Location = new System.Drawing.Point(12, 179);
            this.radioBtn_Competition.Name = "radioBtn_Competition";
            this.radioBtn_Competition.Size = new System.Drawing.Size(105, 22);
            this.radioBtn_Competition.TabIndex = 1;
            this.radioBtn_Competition.Text = "比赛模式";
            this.radioBtn_Competition.UseVisualStyleBackColor = true;
            // 
            // btn_StartServer
            // 
            this.btn_StartServer.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_StartServer.Location = new System.Drawing.Point(11, 285);
            this.btn_StartServer.Name = "btn_StartServer";
            this.btn_StartServer.Size = new System.Drawing.Size(103, 37);
            this.btn_StartServer.TabIndex = 0;
            this.btn_StartServer.Text = "未运行";
            this.btn_StartServer.UseVisualStyleBackColor = true;
            this.btn_StartServer.Click += new System.EventHandler(this.btn_StartServer_Click);
            // 
            // btn_more
            // 
            this.btn_more.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_more.Location = new System.Drawing.Point(250, 387);
            this.btn_more.Name = "btn_more";
            this.btn_more.Size = new System.Drawing.Size(28, 37);
            this.btn_more.TabIndex = 9;
            this.btn_more.Text = ">";
            this.btn_more.UseVisualStyleBackColor = true;
            this.btn_more.Click += new System.EventHandler(this.btn_more_Click);
            // 
            // lbl_serverName
            // 
            this.lbl_serverName.AutoSize = true;
            this.lbl_serverName.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_serverName.Location = new System.Drawing.Point(7, 49);
            this.lbl_serverName.Name = "lbl_serverName";
            this.lbl_serverName.Size = new System.Drawing.Size(142, 24);
            this.lbl_serverName.TabIndex = 4;
            this.lbl_serverName.Text = "服务器名称:";
            // 
            // serverName
            // 
            this.serverName.Font = new System.Drawing.Font("宋体", 10F);
            this.serverName.Location = new System.Drawing.Point(12, 78);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(183, 30);
            this.serverName.TabIndex = 5;
            this.serverName.Text = "Hanlin Major";
            // 
            // cs_server_ctrl
            // 
            this.cs_server_ctrl.Controls.Add(this.radioBtn_solo);
            this.cs_server_ctrl.Controls.Add(this.lbl_maxplayers);
            this.cs_server_ctrl.Controls.Add(this.maxPlayers);
            this.cs_server_ctrl.Controls.Add(this.radioBtn_entertainment);
            this.cs_server_ctrl.Controls.Add(this.lbl_serverName);
            this.cs_server_ctrl.Controls.Add(this.radioBtn_Competition);
            this.cs_server_ctrl.Controls.Add(this.btn_StartServer);
            this.cs_server_ctrl.Controls.Add(this.lbl_ServerStatusText);
            this.cs_server_ctrl.Controls.Add(this.serverName);
            this.cs_server_ctrl.Font = new System.Drawing.Font("宋体", 14F);
            this.cs_server_ctrl.Location = new System.Drawing.Point(13, 92);
            this.cs_server_ctrl.Name = "cs_server_ctrl";
            this.cs_server_ctrl.Size = new System.Drawing.Size(265, 335);
            this.cs_server_ctrl.TabIndex = 6;
            this.cs_server_ctrl.TabStop = false;
            this.cs_server_ctrl.Text = "服务器创建器";
            this.cs_server_ctrl.Enter += new System.EventHandler(this.s);
            // 
            // lbl_maxplayers
            // 
            this.lbl_maxplayers.AutoSize = true;
            this.lbl_maxplayers.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_maxplayers.Location = new System.Drawing.Point(7, 118);
            this.lbl_maxplayers.Name = "lbl_maxplayers";
            this.lbl_maxplayers.Size = new System.Drawing.Size(142, 24);
            this.lbl_maxplayers.TabIndex = 7;
            this.lbl_maxplayers.Text = "最大玩家数:";
            // 
            // maxPlayers
            // 
            this.maxPlayers.Font = new System.Drawing.Font("宋体", 10F);
            this.maxPlayers.FormatString = "N0";
            this.maxPlayers.FormattingEnabled = true;
            this.maxPlayers.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.maxPlayers.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "28",
            "32"});
            this.maxPlayers.Location = new System.Drawing.Point(11, 145);
            this.maxPlayers.Name = "maxPlayers";
            this.maxPlayers.Size = new System.Drawing.Size(121, 28);
            this.maxPlayers.TabIndex = 6;
            this.maxPlayers.Text = "10";
            // 
            // radioBtn_solo
            // 
            this.radioBtn_solo.AutoSize = true;
            this.radioBtn_solo.Font = new System.Drawing.Font("宋体", 9F);
            this.radioBtn_solo.Location = new System.Drawing.Point(12, 238);
            this.radioBtn_solo.Name = "radioBtn_solo";
            this.radioBtn_solo.Size = new System.Drawing.Size(105, 22);
            this.radioBtn_solo.TabIndex = 8;
            this.radioBtn_solo.Text = "单挑模式";
            this.radioBtn_solo.UseVisualStyleBackColor = true;
            this.radioBtn_solo.CheckedChanged += new System.EventHandler(this.radioBtn_solo_CheckedChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_more);
            this.Controls.Add(this.HL);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.downloadProgress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_playerInfo);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.login_name);
            this.Controls.Add(this.title);
            this.Controls.Add(this.cs_server_ctrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.Resizable = false;
            this.Text = "Hanlin Major";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeProcess);
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cs_server_ctrl.ResumeLayout(false);
            this.cs_server_ctrl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HL;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label login_name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label_playerInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar downloadProgress;
        private System.Windows.Forms.Label label_DAC;
        private System.Windows.Forms.Label label_DAC_status;
        private System.Windows.Forms.Label label_teammate;
        private System.Windows.Forms.Label label_teammates4;
        private System.Windows.Forms.Label label_teammates3;
        private System.Windows.Forms.Label label_teammates2;
        private System.Windows.Forms.Label label_teammates1;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Label label_TeamInfo;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_StartServer;
        private System.Windows.Forms.RadioButton radioBtn_Competition;
        private System.Windows.Forms.Label lbl_ServerStatusText;
        private System.Windows.Forms.RadioButton radioBtn_entertainment;
        private System.Windows.Forms.Button btn_more;
        private System.Windows.Forms.Label lbl_serverName;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.GroupBox cs_server_ctrl;
        private System.Windows.Forms.ComboBox maxPlayers;
        private System.Windows.Forms.Label lbl_maxplayers;
        private System.Windows.Forms.RadioButton radioBtn_solo;
    }
}

