namespace HanlinMajor.Form
{
    partial class Message
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.btn_OK = new MetroFramework.Controls.MetroButton();
            this.msgBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_OK.Enabled = false;
            this.btn_OK.Location = new System.Drawing.Point(20, 380);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(760, 50);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseSelectable = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // msgBox
            // 
            // 
            // 
            // 
            this.msgBox.CustomButton.Image = null;
            this.msgBox.CustomButton.Location = new System.Drawing.Point(530, 2);
            this.msgBox.CustomButton.Name = "";
            this.msgBox.CustomButton.Size = new System.Drawing.Size(227, 227);
            this.msgBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.msgBox.CustomButton.TabIndex = 1;
            this.msgBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.msgBox.CustomButton.UseSelectable = true;
            this.msgBox.CustomButton.Visible = false;
            this.msgBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msgBox.Lines = new string[] {
        "Infomation"};
            this.msgBox.Location = new System.Drawing.Point(20, 148);
            this.msgBox.MaxLength = 32767;
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.PasswordChar = '\0';
            this.msgBox.ReadOnly = true;
            this.msgBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.msgBox.SelectedText = "";
            this.msgBox.SelectionLength = 0;
            this.msgBox.SelectionStart = 0;
            this.msgBox.ShortcutsEnabled = true;
            this.msgBox.Size = new System.Drawing.Size(760, 232);
            this.msgBox.TabIndex = 2;
            this.msgBox.Text = "Infomation";
            this.msgBox.UseSelectable = true;
            this.msgBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.msgBox.WaterMarkFont = new System.Drawing.Font("宋体", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.btn_OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "Message";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "信息";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Message_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_OK;
        private MetroFramework.Controls.MetroTextBox msgBox;
    }
}