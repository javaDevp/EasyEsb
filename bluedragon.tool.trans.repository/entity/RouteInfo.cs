using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluedragon.tool.trans.repository.entity
{
    [Table(Name="Route_Info")]
    public class RouteInfo
    {
        [Column(Name="Route_ID")]
        public int RouteID { get; set; }
        [Column(Name="Route_Type")]
        public string RouteType { get; set; }
        [Column(Name="Route_Url")]
        public string RouteUrl { get; set; }
        [Column(Name="Trans_No")]
        public string TransNo { get; set; }
    }
}
