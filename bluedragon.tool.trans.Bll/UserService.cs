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
    public class UserService : IUserService
    {
        public int AddUser(UserInfo userInfo)
        {
            using (var db = new EasyEsb())
            {
                return db.Insert<UserInfo>(userInfo);
            }
        }

        public int RemoveUser(UserInfo userInfo)
        {
            using (var db = new EasyEsb())
            {
                return db.Delete<UserInfo>(userInfo);
            }
        }

        public bool ValidateUser(string userName, string password, string transNo)
        {
            using (var db = new EasyEsb())
            {
                var userInfo = from ui in db.UserInfo
                               from gi in db.GroupInfo.Where(g=>g.GroupID == ui.GroupID)
                               from ai in db.AuthorityInfo.Where(a=>a.UserID == ui.UserID || a.GroupID == gi.GroupID) 
                                   where ui.UserName == userName && ui.Password == password && ai.TransNo == transNo
                                   select ui;
                if (userInfo.Count() != 1)
                    return false;
                return true;
            }
        }
    }
}
