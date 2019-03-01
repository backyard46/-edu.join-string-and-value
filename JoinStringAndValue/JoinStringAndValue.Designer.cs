namespace JoinStringAndValue
{
    partial class JoinStringAndValue
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.TextResult = new System.Windows.Forms.TextBox();
            this.ButtonGo = new System.Windows.Forms.Button();
            this.TextResult2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextResult
            // 
            this.TextResult.Location = new System.Drawing.Point(12, 31);
            this.TextResult.Name = "TextResult";
            this.TextResult.ReadOnly = true;
            this.TextResult.Size = new System.Drawing.Size(248, 27);
            this.TextResult.TabIndex = 0;
            // 
            // ButtonGo
            // 
            this.ButtonGo.Location = new System.Drawing.Point(294, 118);
            this.ButtonGo.Name = "ButtonGo";
            this.ButtonGo.Size = new System.Drawing.Size(120, 32);
            this.ButtonGo.TabIndex = 1;
            this.ButtonGo.Text = "結合";
            this.ButtonGo.UseVisualStyleBackColor = true;
            this.ButtonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // TextResult2
            // 
            this.TextResult2.Location = new System.Drawing.Point(12, 83);
            this.TextResult2.Name = "TextResult2";
            this.TextResult2.ReadOnly = true;
            this.TextResult2.Size = new System.Drawing.Size(248, 27);
            this.TextResult2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "TextResult.Text = \"今は\" + 2000 + 19 + \"年です\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "TextResult2.Text = 2000 + 19 + \"年です\"";
            // 
            // JoinStringAndValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 160);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextResult2);
            this.Controls.Add(this.ButtonGo);
            this.Controls.Add(this.TextResult);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "JoinStringAndValue";
            this.Text = "文字と数値の結合";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextResult;
        private System.Windows.Forms.Button ButtonGo;
        private System.Windows.Forms.TextBox TextResult2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

