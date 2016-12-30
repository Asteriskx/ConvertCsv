using System;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ConvertToCSV
{ 
    /// <summary>
    /// 現在の時刻を表示するToolStripItem
    /// </summary>
    [ToolStripItemDesignerAvailability(
        ToolStripItemDesignerAvailability.StatusStrip)]

    public class DateTimePanel : ToolStripStatusLabel
    {
        // Timer
        private Timer _timer; 

        // Date Format
        private string _format;

        // Timer Interval
        private static readonly int Interval = 100;

        /// <summary>
        /// 表示する日時のフォーマット
        /// </summary>
        [System.Configuration.DefaultSettingValue("")]
        public string Format
        {
            get
            {
                return _format;
            }
            set
            {
                _format = value;
            }
        }
        
        /// <summary>
        /// 外部から変更を禁止し、ここでのみセット
        /// </summary>
        [System.ComponentModel.Browsable(false)]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                // none
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DateTimePanel()
        {
            //初期化
            Format = "";
            base.Text = GetFormattedDateTimeText();

            //タイマーを作成
            _timer = new Timer();
            _timer.Interval = Interval;

            //Tickイベントハンドラの追加
            _timer.Tick += new EventHandler(_timer_Tick);
            _timer.Enabled = true;
        }

        /// <summary>
        /// リソースの解放
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && _timer != null)
            {
                _timer.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// タイマの毎周期更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _timer_Tick(object sender, EventArgs e)
        {
            //Textを更新する
            UpdateText();
        }
        
        /// <summary>
        /// 日時の更新
        /// </summary>
        private void UpdateText()
        {
            //現在の日時を表す文字列を取得する
            string newText = this.GetFormattedDateTimeText();
            //表示する文字列が更新された時、Textを変更する
            if (!base.Text.Equals(newText, StringComparison.Ordinal))
            {
                base.Text = newText;
            }
        }

        /// <summary>
        /// 現在時刻の文字列変換
        /// </summary>
        /// <returns></returns>
        private string GetFormattedDateTimeText()
        {
            return DateTime.Now.ToString(Format);
        }
    }
}

