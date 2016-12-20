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
    public partial class FrmMain : Form
    {
        private MenuStrip menu;

        public FrmMain()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmMain_Load);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
