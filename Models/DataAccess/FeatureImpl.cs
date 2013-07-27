using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;
using tuanva.Core;

namespace Models.DataAccess
{
    public class FeatureImpl
    {
        private static FeatureImpl _impl;
        public static FeatureImpl Instance { get { return _impl ?? (_impl = new FeatureImpl()); } }

        public FeatureInfo GetById(int id)
        {
            var tsql = "select * from Feature where id=@id";
            var param = new[]
                            {
                                new SqlParameter("@id", id)
                            };
            var reader = DataHelper.ExecuteReader(Config.ConnectString, tsql, CommandType.Text, param);
            var info = new FeatureInfo();
            while (reader.Read())
            {
                info.Id = Convert.ToInt16(reader["Id"]);
                info.FeatureName = reader["FuncName"].ToString();
                info.CateProductId = Convert.ToInt16(reader["ProductCateId"]);
                info.IsShare = ConvertUtility.ToBoolean(reader["IsShare"]);
            }
            reader.Close();
            reader.Dispose();
            return info.Id < 1 ? null : info;
        }

        public List<FeatureInfo> GetList(int catepid)
        {
            IDataReader reader;
            var tsql = "SELECT a.*,b.Name FROM Feature a INNER JOIN ProductCategory b ON a.ProductCateId=b.Id";
            if (catepid == 0)
            {
                reader = DataHelper.ExecuteReader(Config.ConnectString, tsql);
            }
            else
            {
                tsql = "SELECT a.*,b.Name FROM Feature a INNER JOIN ProductCategory b ON a.ProductCateId=b.Id AND (a.ProductCateId=@cpid OR ISSHARE=1)";
                reader = DataHelper.ExecuteReader(Config.ConnectString, tsql, CommandType.Text, new[]
                                                                                                    {
                                                                                                        new SqlParameter
                                                                                                            ("@cpid",
                                                                                                             catepid)
                                                                                                    });
            }
            var lst = new List<FeatureInfo>();
            while (reader.Read())
            {
                var info = new FeatureInfo();
                info.Id = Convert.ToInt16(reader["Id"]);
                info.FeatureName = reader["FuncName"].ToString();
                info.CateProductId = Convert.ToInt16(reader["ProductCateId"]);
                info.CateProductName = reader["Name"].ToString();
                info.IsShare = ConvertUtility.ToBoolean(reader["IsShare"]);
                lst.Add(info);
            }
            reader.Close();
            reader.Dispose();
            return lst;
        }

        public int Delete(int id)
        {
            var tsql = "delete from Feature where id=@id";
            var reader = DataHelper.ExecuteNonQuery(Config.ConnectString, tsql, new[] { new SqlParameter("@id", id) }, CommandType.Text);
            return reader;
        }

        public int Add(string fname,int catepid,bool isshare)
        {
            var tsql = "Insert into Feature(FuncName,ProductCateId,IsShare) values(@FuncName,@ProductCateId,@IsShare)";
            var ret = DataHelper.ExecuteNonQuery(Config.ConnectString, tsql, new[]
                                                                                 {
                                                                                     new SqlParameter("@FuncName", fname),
                                                                                     new SqlParameter("@ProductCateId",catepid),
                                                                                     new SqlParameter("@IsShare",isshare) 
                                                                                 }, CommandType.Text);

            return ret;
        }

        public int Update(int id, string fname, int catepid,bool isshare)
        {
            var tsql = "Update Feature set FuncName=@FuncName,ProductCateId=@ProductCateId,IsShare=@IsShare where id=@id";
            var ret = DataHelper.ExecuteNonQuery(Config.ConnectString, tsql, new[]
                                                                                 {
                                                                                     new SqlParameter("@FuncName", fname),
                                                                                     new SqlParameter("@ProductCateId",catepid), 
                                                                                     new SqlParameter("@id",id),
                                                                                     new SqlParameter("@IsShare",isshare) 
                                                                                 }, CommandType.Text);

            return ret;
        }

    }
}
