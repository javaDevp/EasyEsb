using bluedragon.tool.trans.IBll;
using bluedragon.tool.trans.repository;
using bluedragon.tool.trans.repository.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluedragon.tool.trans.Bll
{
    public class MenuService : IMenuService
    {
        private EasyEsb db = null;

        public IEnumerable<MenuInfo> GetAllMenu()
        {
            return null;   
        }
    }
}
