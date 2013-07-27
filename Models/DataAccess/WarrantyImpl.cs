using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;

namespace Models.DataAccess
{
    public class WarrantyImpl
    {
        private static WarrantyImpl _impl;
        public static WarrantyImpl Instance { get { return _impl ?? (_impl = new WarrantyImpl()); } }

        public WarrantyInfo GetById(int id)
        {
            var tsql = "select * from Warranty where id=@id";
            var param = new[]
                            {
                                new SqlParameter("@id", id)
                            };
            var reader = DataHelper.ExecuteReader(Config.ConnectString, tsql,CommandType.Text, param);
            var info = new WarrantyInfo();
            while (reader.Read())
            {
                info.Id = Convert.ToInt16(reader["Id"]);
                info.WarrantyValue = reader["Value"].ToString();
            }
            reader.Close();
            reader.Dispose();
            return info.Id < 1 ? null : info;
        }

        public List<WarrantyInfo> GetList()
        {
            var tsql = "select * from Warranty";
            var reader = DataHelper.ExecuteReader(Config.ConnectString, tsql);
            var lst = new List<WarrantyInfo>();
            while (reader.Read())
            {
                var info = new WarrantyInfo();
                info.Id = Convert.ToInt16(reader["Id"]);
                info.WarrantyValue = reader["Value"].ToString();
                lst.Add(info);
            }
            reader.Close();
            reader.Dispose();
            return lst;
        }

        public int Delete(int id)
        {
            var tsql = "delete from Warranty where id=@id";
            var reader = DataHelper.ExecuteNonQuery(Config.ConnectString, tsql, new[] { new SqlParameter("@id", id) }, CommandType.Text);
            return reader;
        }

        public int Add(string val)
        {
            var tsql = "Insert into Warranty(Value) values(@value)";
            var ret = DataHelper.ExecuteNonQuery(Config.ConnectString, tsql,new[]{new SqlParameter("@value",val)},CommandType.Text);
            
            return ret;
        }

        public int Update(int id,string val)
        {
            var tsql = "Update Warranty set Value=@value where id=@id";
            var ret = DataHelper.ExecuteNonQuery(Config.ConnectString, tsql, new[]
                                                                                 {
                                                                                     new SqlParameter("@value", val),
                                                                                     new SqlParameter("@id",id) 
                                                                                 }, CommandType.Text);

            return ret;
        }

    }
}
