using System.Collections.Generic;
using System.Data.SqlClient;
using Models.Entity;

namespace Models.DataAccess
{
    public class ContactImpl
    {
        private static ContactImpl _imp;
        public static ContactImpl Instance
        {
            get { return _imp ?? (_imp = new ContactImpl()); }
        }

        public int Add(ContactInfo info)
        {
            var param = new[]
                            {
                                new SqlParameter("@FullName", info.FullName),
                                new SqlParameter("@Email", info.Email),
                                new SqlParameter("@Subject", info.Subject),
                                new SqlParameter("@Message", info.Message),
                                new SqlParameter("@Phone", info.Phone)
                            };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_Contact_Add", param);
        }

        public List<ContactInfo> GetList()
        {
            var list = new List<ContactInfo>();
            var dr = DataHelper.ExecuteReader(Config.ConnectString, "select * from Contact");
            if(dr!=null)
            {
                while (dr.Read())
                {
                    var info = new ContactInfo()
                                   {
                                       Id = int.Parse(dr["Id"].ToString()),
                                       Email = dr["Email"].ToString(),
                                       FullName = dr["FullName"].ToString(),
                                       Message = dr["Message"].ToString(),
                                       Phone = dr["Phone"].ToString(),
                                       Subject = dr["Subject"].ToString()
                                   };
                    list.Add(info);
                }
                dr.Close();
                dr.Dispose();
            }
            return list;
        }

        public int Delete(int id)
        {
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "delete from Contact where id=" + id);
        }
    }
}
