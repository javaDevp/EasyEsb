using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluedragon.tool.trans.repository.entity
{
    [Table("Menu_Info")]
    public class MenuInfo
    {
        [Column("Menu_ID")]
        public int MenuID { get; set; }
        [Column("Menu_Name")]
        public string MenuName { get; set; }
        [Column("Menu_Icon")]
        public string MenuIcon { get; set; }
        [Column("Parent_Menu_ID")]
        public int ParentMenuID { get; set; }
        [Column("Target")]
        public string Target { get; set; }
    }
}
