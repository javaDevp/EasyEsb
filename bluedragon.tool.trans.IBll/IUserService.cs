using bluedragon.tool.trans.repository.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluedragon.tool.trans.IBll
{
    public interface IUserService
    {
        int AddUser(UserInfo userInfo);

        int RemoveUser(UserInfo userInfo);

        /// <summary>
        /// 权限验证
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="transNo">交易号</param>
        /// <returns></returns>
        bool ValidateUser(string userName, string password, string transNo);
    }
}
