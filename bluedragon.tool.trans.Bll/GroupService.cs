using bluedragon.tool.trans.IBll;
using bluedragon.tool.trans.repository;
using bluedragon.tool.trans.repository.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;

namespace bluedragon.tool.trans.Bll
{
    public class GroupService : IGroupService
    {
        public int AddGroup(GroupInfo groupInfo)
        {
            using (var db = new EasyEsb())
            {
                return db.Insert<GroupInfo>(groupInfo);
            }
        }

        public int RemoveGroup(GroupInfo groupInfo)
        {
            using (var db = new EasyEsb())
            {
                return db.Delete<GroupInfo>(groupInfo);
            }
        }
    }
}
