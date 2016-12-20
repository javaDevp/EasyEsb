using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluedragon.tool.trans.repository.entity
{
    [Table(Name="User_Info")]
    public class UserInfo
    {
        [Column(Name="User_ID")]
        public int UserID { get; set; }
        [Column(Name = "User_Name")]
        public string UserName { get; set; }
        [Column(Name = "Password")]
        public string Password { get; set; }
        [Column(Name = "Group_ID")]
        public int GroupID { get; set; }
    }
}
