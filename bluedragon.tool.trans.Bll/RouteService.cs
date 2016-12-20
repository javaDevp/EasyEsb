using bluedragon.tool.trans.IBll;
using bluedragon.tool.trans.repository.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using bluedragon.tool.trans.repository;

namespace bluedragon.tool.trans.Bll
{
    public class RouteService : IRouteService
    {
        public int AddRoute(RouteInfo routeInfo)
        {
            using (var db = new EasyEsb())
            {
                return db.Insert<RouteInfo>(routeInfo);
            }
        }

        public int RemoveRoute(RouteInfo routeInfo)
        {
            using (var db = new EasyEsb())
            {
                return db.Delete<RouteInfo>(routeInfo);
            }
        }
    }
}
