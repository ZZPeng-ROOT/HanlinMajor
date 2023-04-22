using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanlinMajor
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string []args)
        {
            foreach (string arg in args)
            {
                switch (arg)
                {
                    case "--hash":
                        try
                        {
                            string hash = utils.GetHash(@"D:\Counter-Strike.zip");
                            FileStream fs = new FileStream(@"D:\Counter-Strike.zip.hash", FileMode.Create);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.Write(hash);
                            sw.Flush();
                            sw.Close();
                            fs.Close();
                        }
                        catch
                        {
                            return;
                        }
                        return;
                    case "--choose-directory":
                        utils.manualUnzip();
                        return;
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}
