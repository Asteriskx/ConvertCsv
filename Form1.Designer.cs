namespace ConvertToCSV
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SavedPath = new System.Windows.Forms.RichTextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.WorkName = new System.Windows.Forms.RichTextBox();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.BarStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.dateTimePanel1 = new ConvertToCSV.DateTimePanel();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConvertButton.ForeColor = System.Drawing.Color.Yellow;
            this.ConvertButton.Location = new System.Drawing.Point(667, 158);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(200, 65);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // SavedPath
            // 
            this.SavedPath.Location = new System.Drawing.Point(80, 21);
            this.SavedPath.Name = "SavedPath";
            this.SavedPath.Size = new System.Drawing.Size(787, 23);
            this.SavedPath.TabIndex = 1;
            this.SavedPath.Text = "";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PathLabel.ForeColor = System.Drawing.Color.Aqua;
            this.PathLabel.Location = new System.Drawing.Point(12, 21);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(62, 24);
            this.PathLabel.TabIndex = 2;
            this.PathLabel.Text = "Path : ";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FileNameLabel.ForeColor = System.Drawing.Color.Aqua;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 61);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(72, 24);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "Name : ";
            // 
            // WorkName
            // 
            this.WorkName.Location = new System.Drawing.Point(80, 61);
            this.WorkName.Name = "WorkName";
            this.WorkName.Size = new System.Drawing.Size(787, 24);
            this.WorkName.TabIndex = 4;
            this.WorkName.Text = "";
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Teal;
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BarStatus,
            this.toolStripStatusLabel2,
            this.dateTimePanel1});
            this.Status.Location = new System.Drawing.Point(0, 239);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(882, 22);
            this.Status.SizingGrip = false;
            this.Status.TabIndex = 5;
            this.Status.Text = "statusStrip1";
            // 
            // BarStatus
            // 
            this.BarStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BarStatus.Name = "BarStatus";
            this.BarStatus.Size = new System.Drawing.Size(55, 17);
            this.BarStatus.Text = "準備完了";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Aqua;
            this.richTextBox1.Location = new System.Drawing.Point(42, 146);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(595, 33);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Path : 作成するファイルの保存場所を指定します。";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox2.ForeColor = System.Drawing.Color.Aqua;
            this.richTextBox2.Location = new System.Drawing.Point(42, 173);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(535, 34);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "Name : 作業内容を記載します。";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox3.ForeColor = System.Drawing.Color.Aqua;
            this.richTextBox3.Location = new System.Drawing.Point(16, 118);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(167, 36);
            this.richTextBox3.TabIndex = 8;
            this.richTextBox3.Text = "<ツール使用方法>";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox4.ForeColor = System.Drawing.Color.Yellow;
            this.richTextBox4.Location = new System.Drawing.Point(41, 201);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(374, 35);
            this.richTextBox4.TabIndex = 9;
            this.richTextBox4.Text = "※「Convert」 でファイル作成を行います。";
            // 
            // dateTimePanel1
            // 
            this.dateTimePanel1.ForeColor = System.Drawing.Color.White;
            this.dateTimePanel1.Format = "";
            this.dateTimePanel1.Margin = new System.Windows.Forms.Padding(680, 3, 0, 2);
            this.dateTimePanel1.Name = "dateTimePanel1";
            this.dateTimePanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePanel1.Size = new System.Drawing.Size(110, 17);
            this.dateTimePanel1.Text = "2016/12/30 23:08:48";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(882, 261);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.WorkName);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.SavedPath);
            this.Controls.Add(this.ConvertButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ConvertCSV Ver.1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.RichTextBox SavedPath;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.RichTextBox WorkName;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel BarStatus;
        private DateTimePanel dateTimePanel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
    }
}

