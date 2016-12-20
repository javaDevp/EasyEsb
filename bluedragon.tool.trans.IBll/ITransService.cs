using bluedragon.tool.trans.repository.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace bluedragon.tool.trans.IBll
{
    public interface ITransService
    {
        int AddTrans(TransInfo transInfo);

        int RemoveTrans(TransInfo transInfo);

        /// <summary>
        /// 根据交易号获取交易的主要配置信息
        /// </summary>
        /// <param name="transNo">交易号</param>
        /// <returns></returns>
        TransInfo GetTransInfo(string transNo);

        /// <summary>
        /// 根据交易号获取交易的字段配置信息
        /// </summary>
        /// <param name="transNo">交易号</param>
        /// <returns></returns>
        IEnumerable<TransFieldInfo> GetTransFieldInfo(string transNo);

        IEnumerable<TransInfo> GetAllTransInfo();

        /// <summary>
        /// 调用交易服务
        /// </summary>
        /// <param name="inputXml">输入XML串</param>
        /// <returns></returns>
        string InvokeTrans(string inputXml);

        /// <summary>
        /// 调用交易服务
        /// </summary>
        /// <param name="xdoc">输入XML串对应的XMLDocument对象</param>
        /// <returns></returns>
        string InvokeTrans(XmlDocument xdoc);
    }
}
