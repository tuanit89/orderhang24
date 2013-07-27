using System.Collections.Generic;
using System.Data.SqlClient;
using Models.Entity;

namespace Models.DataAccess
{
    public class SettingImpl
    {
        private static SettingImpl _info;
        public static SettingImpl Instance { get { return _info ?? (_info = new SettingImpl()); } }

        public int Add(SettingInfo info)
        {
            var param = new[]
                            {
                                new SqlParameter("@Key", info.Key),
                                new SqlParameter("@Value", info.Value),
                                new SqlParameter("@Description",info.Description) 
                            };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_Settings_Add", param);
        }

        public int Update(SettingInfo info)
        {
            var param = new[]
                            {
                                new SqlParameter("@Key", info.Key),
                                new SqlParameter("@Value", info.Value),
                                new SqlParameter("Description",info.Description) 
                            };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_Settings_Update", param);
        }

        public int Delete(string key)
        {
            var param = new[]
                            {
                                new SqlParameter("@Key", key)
                            };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_Settings_Delete", param);
        }

        public SettingInfo GetByKey(string key)
        {
            var param = new[]
                            {
                                new SqlParameter("@Key", key)
                            };
            var info = new SettingInfo();
            var reader = DataHelper.ExecuteReader(Config.ConnectString, "usp_Settings_GetByKey", param);
            while (reader.Read())
            {
                info.Key = reader["Key"].ToString();
                info.Value = reader["Value"].ToString();
                info.Description = reader["Description"].ToString();
            }
            reader.Close();
            reader.Dispose();
            return info;
        }

        public List<SettingInfo> GetList()
        {
            var reader = DataHelper.ExecuteReader(Config.ConnectString, "usp_Settings_GetList");
            var lst = new List<SettingInfo>();
            while (reader.Read())
            {
                var info = new SettingInfo();
                info.Key = reader["Key"].ToString();
                info.Value = reader["Value"].ToString();
                info.Description = reader["Description"].ToString();
                lst.Add(info);
            }
            reader.Close();
            reader.Dispose();
            return lst;
        }
    }
}
