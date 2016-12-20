using bluedragon.tool.trans.repository.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluedragon.tool.trans.IBll
{
    public interface IGroupService
    {
        int AddGroup(GroupInfo groupInfo);

        int RemoveGroup(GroupInfo groupInfo);
    }
}
