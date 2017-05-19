namespace Example11
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
            this.年 = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnludge = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 年
            // 
            this.年.AutoSize = true;
            this.年.Location = new System.Drawing.Point(12, 51);
            this.年.Name = "年";
            this.年.Size = new System.Drawing.Size(29, 12);
            this.年.TabIndex = 0;
            this.年.Text = "西暦";
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(65, 44);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(100, 19);
            this.tbxYear.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "年";
            // 
            // btnludge
            // 
            this.btnludge.Location = new System.Drawing.Point(205, 42);
            this.btnludge.Name = "btnludge";
            this.btnludge.Size = new System.Drawing.Size(75, 23);
            this.btnludge.TabIndex = 3;
            this.btnludge.Text = "判定";
            this.btnludge.UseVisualStyleBackColor = true;
            this.btnludge.Click += new System.EventHandler(this.btnludge_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(143, 107);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(41, 12);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 163);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnludge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.年);
            this.Name = "Form1";
            this.Text = "うるう年判定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 年;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnludge;
        private System.Windows.Forms.Label lblResult;
    }
}

