using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;

namespace Models.DataAccess
{
	public class SupportImpl
	{
	    private static SupportImpl _impl;
	    public static SupportImpl Instance
	    {
            get { return _impl ?? (_impl = new SupportImpl()); }
	    }

        public int Add(SupportInfo info)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@Yahoo", info.Yahoo),
                                       new SqlParameter("@Skype", info.Skype),
                                       new SqlParameter("@Name", info.Name),
                                       new SqlParameter("@Phone", info.Phone)
                                   };
            return int.Parse(DataHelper.ExecuteScalar(Config.ConnectString, "usp_Support_Add", param).ToString());           
        }
        
        public int Update(SupportInfo info)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@Id", info.Id),
                                       new SqlParameter("@Yahoo", info.Yahoo),
                                       new SqlParameter("@Skype", info.Skype),
                                       new SqlParameter("@Name", info.Name),
                                       new SqlParameter("@Phone", info.Phone)
                                   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_Support_Update", param);    
        }


        public int Delete(int id)
        {
            SqlParameter[] param = {
									   new SqlParameter("@Id", id)
			
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_Support_Delete", param);   
        }

        public SupportInfo GetInfo(int id)
        {
            SupportInfo info = null;
			SqlParameter[] param = {
									   new SqlParameter("@Id", id)
			
								   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_Support_GetById", param);
			if (r != null)
			{
				info = new SupportInfo();
				while (r.Read())
				{
					if(r["Id"] != null && !r["Id"].ToString().Equals(""))
					{
						info.Id = Int32.Parse(r["Id"].ToString());
					}
					if(r["Yahoo"] != null && !r["Yahoo"].ToString().Equals(""))
					{
						info.Yahoo = r["Yahoo"].ToString();
					}
					if(r["Skype"] != null && !r["Skype"].ToString().Equals(""))
					{
						info.Skype = r["Skype"].ToString();
					}
					if(r["Name"] != null && !r["Name"].ToString().Equals(""))
					{
						info.Name = r["Name"].ToString();
					}
					if(r["Phone"] != null && !r["Phone"].ToString().Equals(""))
					{
						info.Phone = r["Phone"].ToString();
					}
					
				}
				r.Close();
                r.Dispose();
			}
			return info;
        }
		
		public List<SupportInfo> GetList()
        {
            List<SupportInfo> list = null;
            var t = 0;
            
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_Support_GetList_All", null, out comx);
            if (r != null)
            {
                list = new List<SupportInfo>();
                while (r.Read())
                {
					var info = new SupportInfo();
                    if(r["Id"] != null && !r["Id"].ToString().Equals(""))
					{
						info.Id = Int32.Parse(r["Id"].ToString());
					}
					if(r["Yahoo"] != null && !r["Yahoo"].ToString().Equals(""))
					{
						info.Yahoo = r["Yahoo"].ToString();
					}
					if(r["Skype"] != null && !r["Skype"].ToString().Equals(""))
					{
						info.Skype = r["Skype"].ToString();
					}
					if(r["Name"] != null && !r["Name"].ToString().Equals(""))
					{
						info.Name = r["Name"].ToString();
					}
					if(r["Phone"] != null && !r["Phone"].ToString().Equals(""))
					{
						info.Phone = r["Phone"].ToString();
					}
					
					
                    list.Add(info);
                }
                r.Close();
                r.Dispose();                
            }

            return list;
        }

        public List<SupportInfo> GetList(int pageIndex, int pageSize, out int total)
        {
            List<SupportInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output}
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_Support_GetList", param, out comx);
            if (r != null)
            {
                list = new List<SupportInfo>();
                while (r.Read())
                {
					var info = new SupportInfo();
                    if(r["Id"] != null && !r["Id"].ToString().Equals(""))
					{
						info.Id = Int32.Parse(r["Id"].ToString());
					}
					if(r["Yahoo"] != null && !r["Yahoo"].ToString().Equals(""))
					{
						info.Yahoo = r["Yahoo"].ToString();
					}
					if(r["Skype"] != null && !r["Skype"].ToString().Equals(""))
					{
						info.Skype = r["Skype"].ToString();
					}
					if(r["Name"] != null && !r["Name"].ToString().Equals(""))
					{
						info.Name = r["Name"].ToString();
					}
					if(r["Phone"] != null && !r["Phone"].ToString().Equals(""))
					{
						info.Phone = r["Phone"].ToString();
					}
					
					
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
