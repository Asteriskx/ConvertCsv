using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConvertToCSV
{
    /// <summary>
    /// ConvertCsv メインクラス
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form がロードされた時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            return;
        }

        /// <summary>
        /// Convert ボタン押下時の処理メソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            // StatusStrip のStatusStripLabel を下記メッセージに更新
            BarStatus.Text = "ファイル作成画面の指示に従ってください。";

            // ファイル作成可否の確認メッセージを表示
            DialogResult result = MessageBox.Show( "ファイルを作成しますか？",
                                                   "ファイル作成！",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation,
                                                   MessageBoxDefaultButton.Button2
                                                  );

            // ダイアログの結果を受けて処理
            switch ( result )
            {
                // 「はい」が押下された場合
                case DialogResult.Yes:

                    // CSV 書き込みメソッドコール
                    executeCsv();

                    // StatusStrip のStatusStripLabel を下記メッセージに更新
                    BarStatus.Text = "ファイル作成中...";

                    // ファイル作成完了メッセージ表示
                    MessageBox.Show( "ファイル作成が完了しました。",
                                     "ファイル作成完了！",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Asterisk,
                                     MessageBoxDefaultButton.Button1
                                    );
                    break;
                
                // 「いいえ」が押下された場合
                case DialogResult.No:
                    // StatusStrip のStatusStripLabel を下記メッセージに更新
                    BarStatus.Text = "ファイル未作成！";

                    //ファイル未作成メッセージ表示
                    MessageBox.Show( "ファイル作成されませんでした。",
                                     "ファイル作成中断！",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Asterisk,
                                     MessageBoxDefaultButton.Button1
                                    );
                    break;

                // 上記以外の場合
                default:
                    // StatusStrip のStatusStripLabel を下記メッセージに更新
                    BarStatus.Text ="準備完了";
                    break;

            }

            // StatusStrip のStatusStripLabel を下記メッセージに更新
            BarStatus.Text = "準備完了";

            return;
        }

        /// <summary>
        /// CSV 書き込みメソッド
        /// </summary>
        private void executeCsv()
        {
            // ボタンクリック時の現在時刻を取得
            var time = DateTime.Now;
            var data = WorkName.Text; 

            // CSV用 にテストデータを用意
            var WorkData = new List<List<string>>()
            {
                new List<string>(){ data }
            };

            // ボタンクリック時の時刻をリストに追加
            var date = new List<List<DateTime>>()
            {
                new List<DateTime>(){ time }
            };

            try
            {
                // 保存する Path を取得
                string Path = SavedPath.Text;

                // .csv ファイルを生成し、データを書き込む
                using (var wr = new CsvWriter( Path ))
                {
                    try
                    {
                        wr.Write(date);
                        wr.Write(WorkData);
                    }
                    catch (ArgumentException arg)
                    {
                        // スタックトレース
                        Console.WriteLine(arg.StackTrace);
                    }
                    finally
                    {
                        // none
                    }
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
