using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace W10Translation
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (File.Exists("D:/credential.json"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                _mainForm mf = new _mainForm();
                mf.TopMost = true;
                Application.Run(mf);

            }
            else
            {
                MessageBox.Show("D:/credential.json 不存在 或 Google API 驗證有問題 或 其他問題");
            }
        }


    }
}
