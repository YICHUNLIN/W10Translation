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
            try
            {
                _model = new Model("D:/credential.json");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void _oriEnglishTB_TextChanged(object sender, EventArgs e)
        {
            _resultTB.Text = _model.doTranslate(_oriEnglishTB.Text);
        }

        

        private void _oriEnglishTB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void _oriEnglishTB_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
            }
        }
    }
}
