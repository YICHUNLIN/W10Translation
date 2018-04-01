using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace W10Translation
{
    public partial class MainForm : Form
    {
        private ApiClient _api;
        private DataModel _dmodel;
        private string _logpath;
        private int _TranslationMode = 0;
        
        public MainForm(string path, string logpath)
        {
            InitializeComponent();
            
            //永遠保持最上面
            TopMost = true;
            try
            {
                _logpath = logpath;
                _api = new ApiClient(path);
                _dmodel = new DataModel(logpath);
               
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void _oriEnglishTB_TextChanged(object sender, EventArgs e)
        {
            if ((_oriEnglishTB.Text != "") && (_TranslationMode == 0))
            {
                _resultTB.Text = _dmodel.addQuery(_api.doTranslate(_oriEnglishTB.Text)).Result;
            }
        }
        

        private void _clrBtn_Click(object sender, EventArgs e)
        {
            _oriEnglishTB.Text = "";
        }

        private void _mainForm_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }
        private void _oriEnglishTB_Click(object sender, EventArgs e)
        {
        }

        private void _oriEnglishTB_DoubleClick(object sender, EventArgs e)
        {

            if ((_oriEnglishTB.Text != "") && (_TranslationMode　== 1))
            {
                _resultTB.Text = _dmodel.addQuery(_api.doTranslate(_oriEnglishTB.Text)).Result;
            }
        }

        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _oriEnglishTB.Text = "";
        }

        private void _historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm hf = new HistoryForm(_dmodel);
            hf.TopMost = true;
            hf.ShowDialog();
        }

        /**
         From 關閉中
             */
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dmodel.saveCounter();
        }
    }
}
