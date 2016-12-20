using bluedragon.tool.trans.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bluedragon.tool.trans.ui
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                MyTransSection section = TransConfig.Section;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmTrans());
            }
            catch (Exception ex)
            {
                MessageBoxShow.Error(ex.Message, "错误信息");
            }
        }
    }
}
