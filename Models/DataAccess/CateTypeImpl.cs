using System.Data;
using System.Data.SqlClient;
using Models.Entity;

namespace Models.DataAccess
{
    public class CateTypeImpl
    {
        public static DataTable GetList()
        {
            var dt = new DataTable();
            var dr = DataHelper.ExecuteReader(Config.ConnectString, "select * from CateType");
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            return dt;
        }

        public static CateTypeInfo GetInfo(string cateType)
        {
            CateTypeInfo info = null;
            SqlParameter[] param = {
									   new SqlParameter("@CateType", cateType)
			
								   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_CateType_GetByCateType", param);
            if (r != null)
            {
                info = new CateTypeInfo();
                while (r.Read())
                {
                    info.CateTypeName = r["CateTypeName"].ToString();
                    info.CateType = r["CateType"].ToString();
                }
                r.Close();
                r.Dispose();
            }
            return info;
        }
    }
}
