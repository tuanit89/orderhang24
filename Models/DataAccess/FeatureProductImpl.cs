using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;

namespace Models.DataAccess
{
    public class FeatureProductImpl
    {
        private static FeatureProductImpl _impl;
        public static FeatureProductImpl Instance { get { return _impl ?? (_impl = new FeatureProductImpl()); } }

        public int Add(string val,int fid)
        {
            var tsql = "insert into Feature_Product(FeatureId,Value) values(@featureid,@value)";
            return DataHelper.ExecuteNonQuery(Config.ConnectString, tsql, new[]
                                                                              {
                                                                                  new SqlParameter("@featureid", fid),
                                                                                  new SqlParameter("@value", val)
                                                                              },CommandType.Text);
        }

        public int Update(int id,string val, int fid)
        {
            var tsql = "update Feature_Product set FeatureId=@featureid,Value=@value where id=@id";
            return DataHelper.ExecuteNonQuery(Config.ConnectString, tsql, new[]
                                                                              {
                                                                                  new SqlParameter("@featureid", fid),
                                                                                  new SqlParameter("@value", val),
                                                                                  new SqlParameter("@id",id)
                                                                              },CommandType.Text);
        }

        public int Delete(int id)
        {
            var tsql = "delete from Feature_Product where id=@id";
            return DataHelper.ExecuteNonQuery(Config.ConnectString, tsql, new[]
                                                                              {
                                                                                  new SqlParameter("@id",id)
                                                                              }, CommandType.Text);
        }

        public List<FeatureProductInfo> GetList(int fid)
        {
            var tsql = "select * from Feature_Product where featureid=@featureid";
            var r = DataHelper.ExecuteReader(Config.ConnectString, tsql, CommandType.Text,new[]
                                                                              {
                                                                                  new SqlParameter("@featureid", fid)
                                                                              });
            var lst = new List<FeatureProductInfo>();
            while(r.Read())
            {
                var info = new FeatureProductInfo();
                info.Id = Convert.ToInt32(r["Id"]);
                info.FeatureId = Convert.ToInt32(r["FeatureId"]);
                info.Value = r["Value"].ToString();
                lst.Add(info);
            }
            return lst;
        }

        public FeatureProductInfo GetInfo(int id)
        {
            var tsql = "select fp.*,f.ProductCateId from Feature_Product fp,Feature f where fp.id=@id and f.Id=fp.FeatureId";
            var r = DataHelper.ExecuteReader(Config.ConnectString, tsql, CommandType.Text, new[]
                                                                              {
                                                                                  new SqlParameter("@id", id)
                                                                              });
            var info = new FeatureProductInfo();
            while (r.Read())
            {
                info.Id = Convert.ToInt32(r["Id"]);
                info.FeatureId = Convert.ToInt32(r["FeatureId"]);
                info.Value = r["Value"].ToString();
                info.ProductCateId = Convert.ToInt32(r["ProductCateId"]);
            }
            return info;
        }
    }
}
