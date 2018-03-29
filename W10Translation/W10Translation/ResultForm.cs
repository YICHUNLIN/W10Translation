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
    public partial class ResultForm : Form
    {
        
        public ResultForm(_mainForm form)
        {
            InitializeComponent();
            form.udateEvent += new _mainForm.UpdateResultDelegate(UploadeTextBox);
        }

        public void UploadeTextBox(string s)
        {
            _resultTB.Text = s;
        }
    }
}
