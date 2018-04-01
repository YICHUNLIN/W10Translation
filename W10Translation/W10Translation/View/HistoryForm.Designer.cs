namespace W10Translation
{
    partial class HistoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._timescountlb = new System.Windows.Forms.Label();
            this._wordcountlb = new System.Windows.Forms.Label();
            this._querysLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查詢次數:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "查詢字數:";
            // 
            // _timescountlb
            // 
            this._timescountlb.AutoSize = true;
            this._timescountlb.Location = new System.Drawing.Point(74, 9);
            this._timescountlb.Name = "_timescountlb";
            this._timescountlb.Size = new System.Drawing.Size(11, 12);
            this._timescountlb.TabIndex = 2;
            this._timescountlb.Text = "0";
            // 
            // _wordcountlb
            // 
            this._wordcountlb.AutoSize = true;
            this._wordcountlb.Location = new System.Drawing.Point(209, 9);
            this._wordcountlb.Name = "_wordcountlb";
            this._wordcountlb.Size = new System.Drawing.Size(11, 12);
            this._wordcountlb.TabIndex = 3;
            this._wordcountlb.Text = "0";
            // 
            // _querysLV
            // 
            this._querysLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this._querysLV.Font = new System.Drawing.Font("新細明體", 13F);
            this._querysLV.GridLines = true;
            this._querysLV.Location = new System.Drawing.Point(14, 25);
            this._querysLV.Name = "_querysLV";
            this._querysLV.ShowItemToolTips = true;
            this._querysLV.Size = new System.Drawing.Size(224, 297);
            this._querysLV.TabIndex = 4;
            this._querysLV.UseCompatibleStateImageBehavior = false;
            this._querysLV.View = System.Windows.Forms.View.Details;
            this._querysLV.SelectedIndexChanged += new System.EventHandler(this._querysLV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "原文";
            this.columnHeader1.Width = 731;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 334);
            this.Controls.Add(this._querysLV);
            this.Controls.Add(this._wordcountlb);
            this.Controls.Add(this._timescountlb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HistoryForm";
            this.Text = "歷史查詢紀錄";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _timescountlb;
        private System.Windows.Forms.Label _wordcountlb;
        private System.Windows.Forms.ListView _querysLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}