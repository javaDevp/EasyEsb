using bluedragon.tool.trans.IBll;
using bluedragon.tool.trans.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using bluedragon.tool.trans.repository.entity;

namespace bluedragon.tool.trans.Bll
{
    public class AuthorityService : IAuthorityService
    {
        public int AddAuthority(AuthorityInfo authorityInfo)
        {
            using (var db = new EasyEsb())
            {
                return db.Insert<AuthorityInfo>(authorityInfo);
            }
        }

        public int RemoveAuthority(AuthorityInfo authorityInfo)
        {
            using (var db = new EasyEsb())
            {
                return db.Insert<AuthorityInfo>(authorityInfo);
            }
        }
    }
}
