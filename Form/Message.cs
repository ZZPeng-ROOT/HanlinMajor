using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace HanlinMajor.Form
{
    public partial class Message : MetroForm
    {

        int xWidth = SystemInformation.PrimaryMonitorSize.Width;//获取显示器屏幕宽度
        int yHeight = SystemInformation.PrimaryMonitorSize.Height;//高度
        public Message(string message, string title = "信息", int Height = 200, int Width = 600)
        {
            InitializeComponent();
            Text= title;
            msgBox.Text = message;
            this.Width = Width;
            this.Height = Height;
            msgBox.Height = Height - 100;
            Thread thread = new Thread(show);
            thread.Start();
        }

        private void show()
        {
            Location = new Point(xWidth, 0);
            for (int i = 99; i >= 0; i--)
            {
                Location = new Point(xWidth - Width + (Width * i * i / 10000), 0);
                Thread.Sleep(5);
            }
            btn_OK.Enabled = true;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Thread stopForm = new Thread(stop);
            stopForm.Start();
        }

        private void stop()
        {
            btn_OK.Enabled = false;
            Thread.Sleep(5);
            for (int i = 0; i < 100; i++)
            {
                Location = new Point(xWidth - Width + (Width * i * i / 10000), 0);
                Thread.Sleep(5);
            }
            Close();
            Dispose();
        }
        private void Message_Load(object sender, EventArgs e)
        {

        }
    }
}
