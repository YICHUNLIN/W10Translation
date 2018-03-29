namespace W10Translation
{
    partial class _mainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._oriEnglishTB = new System.Windows.Forms.TextBox();
            this._engLB = new System.Windows.Forms.Label();
            this._resultTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _oriEnglishTB
            // 
            this._oriEnglishTB.Location = new System.Drawing.Point(16, 26);
            this._oriEnglishTB.Multiline = true;
            this._oriEnglishTB.Name = "_oriEnglishTB";
            this._oriEnglishTB.Size = new System.Drawing.Size(230, 250);
            this._oriEnglishTB.TabIndex = 0;
            this._oriEnglishTB.TextChanged += new System.EventHandler(this._oriEnglishTB_TextChanged);
            this._oriEnglishTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this._oriEnglishTB_KeyDown);
            this._oriEnglishTB.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this._oriEnglishTB_PreviewKeyDown);
            // 
            // _engLB
            // 
            this._engLB.AutoSize = true;
            this._engLB.Location = new System.Drawing.Point(197, 11);
            this._engLB.Name = "_engLB";
            this._engLB.Size = new System.Drawing.Size(49, 12);
            this._engLB.TabIndex = 1;
            this._engLB.Text = "英(原文)";
            // 
            // _resultTB
            // 
            this._resultTB.Location = new System.Drawing.Point(291, 26);
            this._resultTB.Multiline = true;
            this._resultTB.Name = "_resultTB";
            this._resultTB.Size = new System.Drawing.Size(276, 250);
            this._resultTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "中(譯文)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(256, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "===>";
            // 
            // _mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._resultTB);
            this.Controls.Add(this._engLB);
            this.Controls.Add(this._oriEnglishTB);
            this.Name = "_mainForm";
            this.Text = "文獻翻譯神器";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _oriEnglishTB;
        private System.Windows.Forms.Label _engLB;
        private System.Windows.Forms.TextBox _resultTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

