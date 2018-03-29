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
    public partial class _mainForm : Form
    {
        private Model _model;

        public _mainForm()
        {
            InitializeComponent();
            //永遠保持最上面
            TopMost = true;
            try
            {
                _model = new Model("D:/credential.json");
               // Thread resultThread = new Thread(ResultThreadCallback);
               // resultThread.Start();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void _oriEnglishTB_TextChanged(object sender, EventArgs e)
        {
            _resultTB.Text = _model.doTranslate(_oriEnglishTB.Text);
           /* if (this.udateEvent != null)
            {
                this.Invoke(this.udateEvent, _model.doTranslate(_oriEnglishTB.Text));
            }*/
        }

        private void ResultThreadCallback()
        {
            ResultForm rf = new ResultForm(this);
            rf.ShowDialog();
        }

        private void _clrBtn_Click(object sender, EventArgs e)
        {
            _oriEnglishTB.Text = "";
        }

        private void _mainForm_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }

        public delegate void UpdateResultDelegate(string s);

        public event UpdateResultDelegate udateEvent;

    }
}
