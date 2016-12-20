using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluedragon.tool.trans.repository.entity
{
    [Table(Name="Authority_Info")]
    public class AuthorityInfo
    {
        [Column(Name="Authority_ID")]
        public int AuthorityID { get; set; }
        [Column(Name="Trans_No")]
        public string TransNo { get; set; }
        [Column(Name="Group_ID")]
        public int GroupID { get; set; }
        [Column(Name="User_ID")]
        public int UserID { get; set; }
    }
}
