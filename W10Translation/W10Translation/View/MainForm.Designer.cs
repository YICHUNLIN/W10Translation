﻿namespace W10Translation
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.清除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._settingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _oriEnglishTB
            // 
            this._oriEnglishTB.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this._oriEnglishTB.Location = new System.Drawing.Point(16, 52);
            this._oriEnglishTB.Multiline = true;
            this._oriEnglishTB.Name = "_oriEnglishTB";
            this._oriEnglishTB.Size = new System.Drawing.Size(405, 154);
            this._oriEnglishTB.TabIndex = 0;
            this._oriEnglishTB.Click += new System.EventHandler(this._oriEnglishTB_Click);
            this._oriEnglishTB.TextChanged += new System.EventHandler(this._oriEnglishTB_TextChanged);
            this._oriEnglishTB.DoubleClick += new System.EventHandler(this._oriEnglishTB_DoubleClick);
            // 
            // _engLB
            // 
            this._engLB.AutoSize = true;
            this._engLB.Location = new System.Drawing.Point(14, 37);
            this._engLB.Name = "_engLB";
            this._engLB.Size = new System.Drawing.Size(49, 12);
            this._engLB.TabIndex = 1;
            this._engLB.Text = "英(原文)";
            // 
            // _resultTB
            // 
            this._resultTB.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._resultTB.Location = new System.Drawing.Point(16, 224);
            this._resultTB.Multiline = true;
            this._resultTB.Name = "_resultTB";
            this._resultTB.Size = new System.Drawing.Size(405, 218);
            this._resultTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "中(譯文)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除ToolStripMenuItem,
            this._historyToolStripMenuItem,
            this._settingMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(431, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 清除ToolStripMenuItem
            // 
            this.清除ToolStripMenuItem.Name = "清除ToolStripMenuItem";
            this.清除ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.清除ToolStripMenuItem.Text = "清除";
            this.清除ToolStripMenuItem.Click += new System.EventHandler(this.清除ToolStripMenuItem_Click);
            // 
            // _historyToolStripMenuItem
            // 
            this._historyToolStripMenuItem.Name = "_historyToolStripMenuItem";
            this._historyToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this._historyToolStripMenuItem.Text = "歷史查詢紀錄";
            this._historyToolStripMenuItem.Click += new System.EventHandler(this._historyToolStripMenuItem_Click);
            // 
            // _settingMenuItem
            // 
            this._settingMenuItem.Name = "_settingMenuItem";
            this._settingMenuItem.Size = new System.Drawing.Size(67, 20);
            this._settingMenuItem.Text = "翻譯模式";
            this._settingMenuItem.Click += new System.EventHandler(this._settingMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._resultTB);
            this.Controls.Add(this._engLB);
            this.Controls.Add(this._oriEnglishTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "文獻翻譯神器";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this._mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _oriEnglishTB;
        private System.Windows.Forms.Label _engLB;
        private System.Windows.Forms.TextBox _resultTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _settingMenuItem;
    }
}

