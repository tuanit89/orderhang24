using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Models.Entity;

namespace Models.DataAccess
{
    public class PropertyProductImpl
    {
        private static PropertyProductImpl _impl;
        public static PropertyProductImpl Instance { get { return _impl ?? (_impl = new PropertyProductImpl()); } }

        public List<int> GetList(int pid)
        {
            var tsql = "SELECT FeatureValueId FROM Feature_Value where ProductId=@id";
            var r = DataHelper.ExecuteReader(Config.ConnectString, tsql, CommandType.Text, new[]
                                                                                               {
                                                                                                   new SqlParameter("@id", pid)
                                                                                               });
            List<int> lst = null;
            if (r != null)
            {
                lst = new List<int>();
                while (r.Read())
                {
                    var key = int.Parse(r["FeatureValueId"].ToString());
                    //info.FeatureId = Convert.ToInt32("FeatureId");
                    lst.Add(key);
                }
                r.Close();
                r.Dispose();
            }
            return lst;
        }

        public bool AddListProperties(List<int> dic,int pid)
        {
            var command = new StringBuilder("DELETE FROM Feature_Value WHERE ProductId="+pid);
            command.Append(" INSERT INTO Feature_Value([ProductId],[FeatureValueId]) VALUES");
            foreach (var i in dic)
            {
                command.AppendFormat("({0},{1}),",pid,i);
            }
            var tsql = command.ToString(0, command.Length - 1);
            var r = DataHelper.ExecuteNonQuery(Config.ConnectString, tsql);
            return r > 0;
        }

        public int Delete(int id)
        {
            var tsql = "DELETE FROM Feature_Value WHERE ProductId=" + id;
            return DataHelper.ExecuteNonQuery(Config.ConnectString, tsql);
        }

        public List<PropertyProductInfo> GetListProperties(int pid,int top)
        {
            string tsql;
            if(top==0) tsql= "SELECT f.FuncName,fp.Value " +
                       "FROM Feature_Value fv " +
                       "inner join Feature_Product fp on fv.FeatureValueId = fp.Id " +
                       "inner join Feature f on f.Id=fp.FeatureId " +
                       "and ProductId=@id";
            else
                tsql =  "SELECT top "+top+" f.FuncName,fp.Value " +
                       "FROM Feature_Value fv " +
                       "inner join Feature_Product fp on fv.FeatureValueId = fp.Id " +
                       "inner join Feature f on f.Id=fp.FeatureId " +
                       "and ProductId=@id";
            var r = DataHelper.ExecuteReader(Config.ConnectString, tsql, CommandType.Text, new[]
                                                                                               {
                                                                                                   new SqlParameter("@id", pid)
                                                                                               });
            List<PropertyProductInfo> lst = null;
            if (r != null)
            {
                lst = new List<PropertyProductInfo>();
                while (r.Read())
                {
                    var info = new PropertyProductInfo();
                    info.FeatureName = r["FuncName"].ToString();
                    info.FeatureValue = r["Value"].ToString();
                    lst.Add(info);
                }
                r.Close();
                r.Dispose();
            }
            return lst;
        }
    }
}
