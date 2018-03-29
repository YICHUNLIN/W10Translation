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
    public partial class _mainForm : Form
    {
        public Model _model;
        public _mainForm()
        {
            InitializeComponent();
            //永遠保持最上面
            TopMost = true;
            _model = new Model("C:/Users/vic/Documents/GitHub/W10Translation/W10Translation/windowsFormDesktopApp-4d2e479727c9.json");
        }

        private void _oriEnglishTB_TextChanged(object sender, EventArgs e)
        {
            _resultTB.Text = _model.doTranslate(_oriEnglishTB.Text);
        }



    }
}
