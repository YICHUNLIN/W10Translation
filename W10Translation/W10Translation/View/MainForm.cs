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
        private Configer _config;
        private string _baseTitle = "文獻翻譯神器";
        public MainForm(Configer config)
        {
            InitializeComponent();
            
            //永遠保持最上面
            TopMost = true;
            try
            {
                _config = config;
                _api = new ApiClient(_config.FullCredential);
                _dmodel = new DataModel(_config.Configxml.LogPath);
                this.setTheFormTitle();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void _oriEnglishTB_TextChanged(object sender, EventArgs e)
        {
            if ((_oriEnglishTB.Text != "") && (_config.SettingConfigxml.TransLationMode == 0))
            {
                _resultTB.Text = _dmodel.addQuery(_api.doTranslate(_oriEnglishTB.Text)).Result;
            }
            if(_oriEnglishTB.Text == "")
            {
                _resultTB.Text = "";
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

            if ((_oriEnglishTB.Text != "") && (_config.SettingConfigxml.TransLationMode == 1))
            {
                _resultTB.Text = _dmodel.addQuery(_api.doTranslate(_oriEnglishTB.Text)).Result;
            }
            if (_oriEnglishTB.Text == "")
            {
                _resultTB.Text = "";
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

        private void _settingMenuItem_Click(object sender, EventArgs e)
        {
            if (_config.SettingConfigxml.TransLationMode == 0)
            {
                _config.SettingConfigxml.TransLationMode = 1;
            }
            else
            {
                _config.SettingConfigxml.TransLationMode = 0;
            }
            _config.SaveSettingXml();
            this.setTheFormTitle();
        }
        private void setTheFormTitle()
        {
            if(_config.SettingConfigxml.TransLationMode == 0)
            {
                this.Text = this._baseTitle + "(即時翻譯模式)";
            }else
            {
                this.Text = this._baseTitle + "(點兩下翻譯模式)";
            }
        }
    }
}
