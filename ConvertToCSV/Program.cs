using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ConvertToCSV
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashControl sc = new SplashControl();
            sc.Show();
            sc.Refresh();
            Thread.Sleep(5000); // 時間のかかる処理
            sc.Close();

            Application.Run(new Form1());
        }
    }
}
