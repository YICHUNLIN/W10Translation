﻿namespace W10Translation
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._resultTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _resultTB
            // 
            this._resultTB.Font = new System.Drawing.Font("新細明體", 20F);
            this._resultTB.Location = new System.Drawing.Point(12, 12);
            this._resultTB.Multiline = true;
            this._resultTB.Name = "_resultTB";
            this._resultTB.Size = new System.Drawing.Size(781, 187);
            this._resultTB.TabIndex = 0;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 211);
            this.Controls.Add(this._resultTB);
            this.Name = "ResultForm";
            this.Text = "翻譯結果";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _resultTB;
    }
}