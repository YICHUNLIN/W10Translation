namespace W10Translation
{
    partial class SettingForm
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
            this._realTimeTransCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _realTimeTransCB
            // 
            this._realTimeTransCB.AutoSize = true;
            this._realTimeTransCB.Location = new System.Drawing.Point(12, 12);
            this._realTimeTransCB.Name = "_realTimeTransCB";
            this._realTimeTransCB.Size = new System.Drawing.Size(224, 16);
            this._realTimeTransCB.TabIndex = 0;
            this._realTimeTransCB.Text = "即時翻譯(即時翻譯可能造成帳單爆表)";
            this._realTimeTransCB.UseVisualStyleBackColor = true;
            this._realTimeTransCB.CheckedChanged += new System.EventHandler(this._realTimeTransCB_CheckedChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 40);
            this.Controls.Add(this._realTimeTransCB);
            this.Name = "SettingForm";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _realTimeTransCB;
    }
}