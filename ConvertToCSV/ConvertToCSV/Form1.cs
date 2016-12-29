using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConvertToCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            return;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            executeCsv(); // CSV 書き込みメソッドコール
            return;
        }

        /// <summary>
        /// CSV 書き込みメソッド
        /// </summary>
        private void executeCsv()
        {
            // ボタンクリック時の現在時刻を取得
            var time = DateTime.Now;

            // CSV用 にテストデータを用意
            var data = new List<List<int>>()
            {
                new List<int>(){ 1, 2, 3, 4, 5 },
                new List<int>(){ 1, 1, 1, 1 ,1 },
            };

            // ボタンクリック時の時刻をリストに追加
            var date = new List<List<DateTime>>()
            {
                new List<DateTime>(){ time }
            };

            try
            {
                // .csv ファイルを生成し、データを書き込む
                using (var wr = new CsvWriter(@"C:\Users\Asterisk\Desktop\hoge.csv"))
                {
                    wr.Write(data);
                    wr.Write(date);
                }
            }
            catch (Exception ex)
            {
                // スタックトレース
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                // none
            }

            #region ※コメントアウト
            /* 1 Record Read */
            /*
            List<string> row = null;
            using (var csv = new CsvReader(@"TestData.csv"))
            {
                while ((row = csv.ReadRow()) != null)
                {
                    Console.WriteLine(row[0].ToString());
                }
            }
            */

            /* All Read */
            /*
            List<List<string>> data = null;

                using (var csv = new CsvReader(@"TestData.csv"))
                {
                    data = csv.ReadToEnd();
                }
            }
            */
            #endregion

            return;
        }

    }
}
