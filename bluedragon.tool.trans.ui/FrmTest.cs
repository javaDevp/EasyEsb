using bluedragon.tool.trans.Bll;
using bluedragon.tool.trans.common;
using bluedragon.tool.trans.IBll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace bluedragon.tool.trans.ui
{
    public partial class FrmTest : Form
    {
        private ITransService _service;
        public FrmTest()
        {
            InitializeComponent();
            //TODO 后期通过依赖注入实现分离
            _service = new TransService();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (string.IsNullOrEmpty(rtxtInput.Text))
                {
                    MessageBoxShow.Info("请先输入测试XML", "");
                }
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(rtxtInput.Text);
                rtxtOutput.Text = _service.InvokeTrans(xdoc);
            }
            catch (Exception ex)
            {
                MessageBoxShow.Error(ex.Message, "");
            }
        }
    }
}
