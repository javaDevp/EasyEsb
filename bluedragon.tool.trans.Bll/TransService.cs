using bluedragon.tool.trans.IBll;
using bluedragon.tool.trans.repository;
using bluedragon.tool.trans.repository.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using System.Xml;
using System.Data;
using System.Data.SqlClient;

namespace bluedragon.tool.trans.Bll
{
    
    public class TransService : ITransService
    {
        public int AddTrans(TransInfo transInfo)
        {
            using (var db = new EasyEsb())
            {
                return db.Insert<TransInfo>(transInfo);
            }
        }

        public int RemoveTrans(TransInfo transInfo)
        {
            using (var db = new EasyEsb())
            {
                return db.Delete<TransInfo>(transInfo);
            }
        }

        public TransInfo GetTransInfo(string transNo)
        {
            using (var db = new EasyEsb())
            {
                var tis = from ti in db.TransInfo
                          where ti.TransNo == transNo
                          select ti;
                return tis.First();
            }
        }

        public IEnumerable<TransFieldInfo> GetTransFieldInfo(string transNo)
        {
            using (var db = new EasyEsb())
            {
                var tfis = from tfi in db.TransFieldInfo
                           from ti in db.TransInfo.Where(t => t.TransID == tfi.TransID)
                           where ti.TransNo == transNo
                           select tfi;
                return tfis;
            }
        }

        public IEnumerable<TransInfo> GetAllTransInfo()
        {
            using (var db = new EasyEsb())
            {
                return db.TransInfo;
            }
        }

        public string InvokeTrans(string inputXml)
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(inputXml);
                return InvokeTrans(xdoc);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string InvokeTrans(XmlDocument xdoc)
        {
            using (var db = new EasyEsb())
            {
                try
                {
                    UserService userService = new UserService();
                    string userName = xdoc.SelectSingleNode("request/header/userid").InnerText;
                    string password = xdoc.SelectSingleNode("request/header/password").InnerText;
                    string transNo = xdoc.SelectSingleNode("request/header/trans_no").InnerText;
                    if (userService.ValidateUser(userName, password, transNo))
                    {
                        TransInfo ti = GetTransInfo(transNo);
                        IEnumerable<TransFieldInfo> tfis = GetTransFieldInfo(transNo);

                        #region 执行配置语句
                        db.Command.CommandType = CommandType.Text;
                        db.Command.CommandText = ti.Sql;
                        var tfisIn = tfis.Where(tfi=>tfi.FieldDirection == false);
                        foreach (TransFieldInfo tfi in tfisIn)
                        {
                            //TODO 后期提为通用版本
                            db.Command.Parameters.Add(new SqlParameter(tfi.DFieldName, 
                                xdoc.SelectSingleNode(string.Format("request/body/{0}", tfi.FieldName)).InnerText));
                        }
                        
                        SqlDataAdapter sda = new SqlDataAdapter((SqlCommand)db.Command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        var tfisOut = tfis.Where(tfi => tfi.FieldDirection == true);
                        foreach (TransFieldInfo tfi in tfisOut)
                        {
                            dt.Columns[tfi.DFieldName].ColumnName = tfi.FieldName;
                        }
                        DataSet ds = new DataSet();
                        ds.Tables.Add(dt);
                        return ds.GetXml();
                            #region 模式1 要求配置顺序
                        //IDataReader sdr = db.Command.ExecuteReader();
                        //var tfisOut = tfis.Where(tfi => tfi.FieldDirection == true);

                        //DataTable dt = new DataTable();
                        //foreach (TransFieldInfo tfi in tfisOut)
                        //{
                        //    dt.Columns.Add(tfi.FieldName);
                        //}

                        //while (sdr.Read())
                        //{
                        //    DataRow dr = dt.NewRow();
                        //    int i = 0;
                        //    foreach (TransFieldInfo tfi in tfisOut)
                        //    {
                        //        dr[tfi.FieldName] = sdr.GetValue(i++);
                        //    }
                        //    dt.Rows.Add(dr);
                        //}
                        //DataSet ds = new DataSet();
                        //ds.Tables.Add(dt);
                        //return ds.GetXml();
                            #endregion
                        #endregion
                    }
                    return "error";
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
