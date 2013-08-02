using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Models.DataAccess
{
    public class TagsImpl
    {
        public static List<string> GetListTags()
        {
            var dr = DataHelper.ExecuteReader(Config.ConnectString, "select TagsName from Tags");
            var lst = new List<string>();
            while (dr.Read())
            {
                lst.Add(dr["TagsName"].ToString());
            }
            dr.Close();
            dr.Dispose();
            return lst;
        }

        public static int AddIfExist(string tags)
        {
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "TagsAdd",new []
                                                                                  {
                                                                                      new SqlParameter("@tags",tags)
                                                                                  }); 
        }
    }
}
