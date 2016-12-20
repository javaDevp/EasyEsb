using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using bluedragon.tool.trans.repository.entity;
using System.Configuration;
using LinqToDB.Data;

namespace bluedragon.tool.trans.repository
{
    public class EasyEsb : DataConnection
    {
        #region Constructor
        public EasyEsb()
            : base("EasyEsb")
        {
        }
        #endregion

        #region Properties
        public ITable<TransInfo> TransInfo 
        { 
            get { return this.GetTable<TransInfo>(); } 
        }

        public ITable<TransFieldInfo> TransFieldInfo
        {
            get { return this.GetTable<TransFieldInfo>(); }
        }

        public ITable<UserInfo> UserInfo
        {
            get { return this.GetTable<UserInfo>(); }
        }

        public ITable<RouteInfo> RouteInfo
        {
            get { return this.GetTable<RouteInfo>(); }
        }

        public ITable<GroupInfo> GroupInfo
        {
            get { return this.GetTable<GroupInfo>(); }
        }

        public ITable<MenuInfo> MenuInfo
        {
            get { return this.GetTable<MenuInfo>(); }
        }

        public ITable<AuthorityInfo> AuthorityInfo
        {
            get { return this.GetTable<AuthorityInfo>(); }
        }
        #endregion
    }
}
