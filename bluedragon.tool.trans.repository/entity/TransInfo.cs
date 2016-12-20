using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluedragon.tool.trans.repository.entity
{
    [Table(Name="Trans_Info")]
    public class TransInfo
    {
        [Column(Name="Trans_ID")]
        public int TransID { get; set; }
        [Column(Name="Trans_No")]
        public string TransNo { get; set; }
        [Column(Name = "SQL")]
        public string Sql { get; set; }
    }
}
