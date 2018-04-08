using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W10Translation
{
    public partial class SettingForm : Form
    {
        Configer _config = null;
        public SettingForm(Configer config)
        {
            InitializeComponent();
            _config = config;
            _realTimeTransCB.Checked = (_config.SettingConfigxml.TransLationMode == 0);
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void _realTimeTransCB_CheckedChanged(object sender, EventArgs e)
        {
            if (_realTimeTransCB.Checked)
            {
                _config.SettingConfigxml.TransLationMode = 0;
            }
            else
            {
                _config.SettingConfigxml.TransLationMode = 1;
            }
            _config.SaveSettingXml();
        }
    }
}
