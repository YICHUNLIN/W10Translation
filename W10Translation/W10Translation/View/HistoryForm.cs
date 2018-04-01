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
    public partial class HistoryForm : Form
    {
        DataModel _dmodel = null;
        public HistoryForm(DataModel dm)
        {
            InitializeComponent();
            _dmodel = dm;
            _timescountlb.Text = _dmodel.TimesCount.ToString();
            _wordcountlb.Text = _dmodel.WordCount.ToString();
            
            this.CreateListViewData();
        }

        private void CreateListViewData()
        {
            foreach (Query q in _dmodel.Qs)
            {
                ListViewItem lvi = new ListViewItem(q.Ori);
                _querysLV.Items.Add(lvi);
            }
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void _querysLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indices = _querysLV.SelectedIndices;
            if(indices.Count > 0)
            {
                ShowSelectedHistoryForm sshf = new ShowSelectedHistoryForm(_dmodel.getQueryByIndex(indices[0]));
                sshf.TopMost = true;
                sshf.ShowDialog();
            }
        }
    }
}
