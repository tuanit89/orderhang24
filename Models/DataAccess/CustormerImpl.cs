using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;
using tuanva.Core;

namespace Models.DataAccess
{
    public class CustormerImpl
    {
        private static CustormerImpl _CustormerImpl;
        public static CustormerImpl Instance
        {
            get { return _CustormerImpl ?? (_CustormerImpl = new CustormerImpl()); }
        }

        public int Add(CustormerInfo info)
        {
            SqlParameter[] param = {
			    new SqlParameter("@Email", info.Email),
			    new SqlParameter("@FirstName", info.FirstName),
			    new SqlParameter("@Lastname", info.Lastname),
			    new SqlParameter("@Password", info.Password),
			    new SqlParameter("@Phone", info.Phone),
			    new SqlParameter("@Address", info.Address),
			    new SqlParameter("@Active", info.Active)			
		   };
            return int.Parse(DataHelper.ExecuteScalar(Config.ConnectString, "usp_tblCustormer_Add", param).ToString());
        }

        public int Update(CustormerInfo info)
        {
            SqlParameter[] param = {
									   new SqlParameter("@id", info.id),
                                       //new SqlParameter("@Email", info.Email),
			                           new SqlParameter("@FirstName", info.FirstName),
			                           new SqlParameter("@Lastname", info.Lastname),
			                           //new SqlParameter("@Password", info.Password),
			                           new SqlParameter("@Phone", info.Phone),
			                           new SqlParameter("@Address", info.Address),
			                           new SqlParameter("@Active", info.Active)			
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_tblCustormer_Update", param);
        }

        public int UpdateActive(int id, bool Active)
        {
            SqlParameter[] param = {
									   new SqlParameter("@id", id),
			                           new SqlParameter("@Active", Active)			
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_tblCustormer_UpdateActive", param);
        }

        public int UpdatePassword(int id, string password)
        {
            SqlParameter[] param = {
									   new SqlParameter("@id", id),
			                           new SqlParameter("@password", password)			
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_tblCustormer_UpdatePassword", param);
        }

        public int CheckExist(string email)
        {
            SqlParameter[] param = {
									   new SqlParameter("@Email", email)	
								   };
            int n = 0;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_tblCustormer_CheckExist", param);
            if (r != null)
            {
                while (r.Read())
                {
                    n = Int32.Parse(r["id"].ToString());
                }
                r.Close();
                r.Dispose();
            }
            return n;
        }

        public CustormerInfo Login(string email, string password)
        {
            CustormerInfo info=null;
            SqlParameter[] param = {
									   new SqlParameter("@Email", email),
			                           new SqlParameter("@password", password)			
								   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_tblCustormer_Login", param);
            if (r != null)
            {
                info = new CustormerInfo();
                while (r.Read())
                {
                    info.id = Int32.Parse(r["id"].ToString());
                    info.Email = r["Email"].ToString();
                    info.FirstName = r["FirstName"].ToString();
                    info.Lastname = r["Lastname"].ToString();
                    info.Phone = r["Phone"].ToString();
                    info.Address = r["Address"].ToString();
                    info.Active = Convert.ToBoolean(r["Active"]);
                    info.CreateDate = Convert.ToDateTime(r["CreateDate"]);
                }
                r.Close();
                r.Dispose();
            }
            return info;
        }

        public int Delete(int id)
        {
            SqlParameter[] param = {
									   new SqlParameter("@id", id)
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_tblCustormer_Delete", param);
        }

        public CustormerInfo GetInfo(int id)
        {
            CustormerInfo info = null;
            SqlParameter[] param = {
									   new SqlParameter("@id", id)
								   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_tblCustormer_GetById", param);
            if (r != null)
            {
                info = new CustormerInfo();
                while (r.Read())
                {
                    info.id = Int32.Parse(r["id"].ToString());
                    info.Email = r["Email"].ToString();
                    info.FirstName = r["FirstName"].ToString();
                    info.Lastname = r["Lastname"].ToString();
                    //info.Password = r["Password"].ToString();
                    info.Phone = r["Phone"].ToString();
                    info.Address = r["Address"].ToString();
                    info.Active = Convert.ToBoolean(r["Active"]);
                    info.CreateDate = Convert.ToDateTime(r["CreateDate"]);

                }
                r.Close();
                r.Dispose();
            }
            return info;
        }

        public List<CustormerInfo> GetList(int pageIndex, int pageSize, out int total)
        {
            List<CustormerInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output}
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_tblCustormer_GetList", param, out comx);
            if (r != null)
            {
                list = new List<CustormerInfo>();
                while (r.Read())
                {
                    var info = new CustormerInfo();
                    info.id = Int32.Parse(r["id"].ToString());
                    info.Email = r["Email"].ToString();
                    info.FirstName = r["FirstName"].ToString();
                    info.Lastname = r["Lastname"].ToString();
                    //info.Password = r["Password"].ToString();
                    info.Phone = r["Phone"].ToString();
                    info.Address = r["Address"].ToString();
                    info.Active = Convert.ToBoolean(r["Active"]);
                    info.CreateDate = Convert.ToDateTime(r["CreateDate"]);


                    list.Add(info);
                }
                r.Close();
                r.Dispose();
                t = int.Parse(comx.Parameters[2].Value.ToString());
            }

            total = t;
            return list;
        }
    }
}
