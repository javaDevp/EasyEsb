using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluedragon.tool.trans.repository.entity
{
    [Table(Name="Group_Info")]
    public class GroupInfo
    {
        [Column(Name="Group_ID")]
        public int GroupID { get; set; }
        [Column(Name="Group_Name")]
        public string GroupName { get; set; }
    }
}
