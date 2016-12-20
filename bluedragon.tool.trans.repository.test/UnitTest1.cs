using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bluedragon.tool.trans.repository.entity;
using System.Configuration;

namespace bluedragon.tool.trans.repository.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            using (EasyEsb db = new EasyEsb())
            {
                var transInfos = db.TransInfo;
                foreach (var tran in transInfos)
                {
                    Console.WriteLine(tran.TransID);
                }
            }
        }
    }
}
