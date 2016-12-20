using bluedragon.tool.trans.Bll;
using bluedragon.tool.trans.IBll;
using bluedragon.tool.trans.repository.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bluedragon.tool.trans.ui
{
    public partial class FrmTrans : Form
    {
        private ITransService _service;

        public FrmTrans()
        {
            _service = new TransService();
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            lvwTransInfo.Columns.Clear();
            lvwTransInfo.Columns.Add("交易号");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var tis = _service.GetAllTransInfo();
            if(!string.IsNullOrEmpty(txtTransNo.Text))
                tis = from ti in tis
                      where ti.TransNo == txtTransNo.Text
                      select ti;
            
            lvwTransInfo.Items.Clear();
            foreach (var ti in tis)
            {
                lvwTransInfo.Items.Add(new ListViewItem(ti.TransNo));
            }
        }
    }
}
