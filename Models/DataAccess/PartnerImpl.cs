using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;

namespace Models.DataAccess
{
    public class PartnerImpl
    {
        private static PartnerImpl _partnerImpl;
        public static PartnerImpl Instance
        {
            get { return _partnerImpl ?? (_partnerImpl = new PartnerImpl()); }
        }
        public int Add(PartnerInfo info)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@Name", info.Name),
                                       new SqlParameter("@Link", info.Link),
                                       new SqlParameter("@Description", info.Description),
                                       new SqlParameter("@Image", info.Image),
                                       new SqlParameter("@Alt", info.Alt)
                                   };
            return int.Parse(DataHelper.ExecuteScalar(Config.ConnectString, "new_Partner_Add", param).ToString());
        }

        public int Update(PartnerInfo info)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@Id", info.Id)
                                       , new SqlParameter("@Name", info.Name),
                                       new SqlParameter("@Link", info.Link),
                                       new SqlParameter("@Description", info.Description),
                                       new SqlParameter("@Image", info.Image),
                                       new SqlParameter("@Alt", info.Alt)
                                   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "new_Partner_Update", param);
        }


        public int Delete(int id)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@Id", id)
                                   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "new_Partner_Delete", param);
        }

        public PartnerInfo GetInfo(int id)
        {
            PartnerInfo info = null;
            SqlParameter[] param = {
                                       new SqlParameter("@Id", id)
                                   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "new_Partner_GetById", param);
            if (r != null)
            {
                info = new PartnerInfo();
                while (r.Read())
                {
                    if (r["Id"] != null && !r["Id"].ToString().Equals(""))
                    {
                        info.Id = Int32.Parse(r["Id"].ToString());
                    }
                    if (r["Name"] != null && !r["Name"].ToString().Equals(""))
                    {
                        info.Name = r["Name"].ToString();
                    }
                    if (r["Link"] != null && !r["Link"].ToString().Equals(""))
                    {
                        info.Link = r["Link"].ToString();
                    }
                    if (r["Description"] != null && !r["Description"].ToString().Equals(""))
                    {
                        info.Description = r["Description"].ToString();
                    }
                    if (r["Image"] != null && !r["Image"].ToString().Equals(""))
                    {
                        info.Image = r["Image"].ToString();
                    }
                    if (r["Alt"] != null && !r["Alt"].ToString().Equals(""))
                    {
                        info.Alt = r["Alt"].ToString();
                    }
                }
                r.Close();
                r.Dispose();
            }
            return info;
        }

        public List<PartnerInfo> GetList()
        {
            List<PartnerInfo> list = null;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "new_Partner_GetList_All");
            if (r != null)
            {
                list = new List<PartnerInfo>();
                while (r.Read())
                {
                    var info = new PartnerInfo();
                    if (r["Id"] != null && !r["Id"].ToString().Equals(""))
                    {
                        info.Id = Int32.Parse(r["Id"].ToString());
                    }
                    if (r["Name"] != null && !r["Name"].ToString().Equals(""))
                    {
                        info.Name = r["Name"].ToString();
                    }
                    if (r["Link"] != null && !r["Link"].ToString().Equals(""))
                    {
                        info.Link = r["Link"].ToString();
                    }
                    if (r["Description"] != null && !r["Description"].ToString().Equals(""))
                    {
                        info.Description = r["Description"].ToString();
                    }
                    if (r["Image"] != null && !r["Image"].ToString().Equals(""))
                    {
                        info.Image = r["Image"].ToString();
                    }
                    if (r["Alt"] != null && !r["Alt"].ToString().Equals(""))
                    {
                        info.Alt = r["Alt"].ToString();
                    }
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
            }

            return list;
        }

        public List<PartnerInfo> GetList(int pageIndex, int pageSize, out int total)
        {
            List<PartnerInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex", pageIndex),
                                       new SqlParameter("@pageSize", pageSize),
                                       new SqlParameter("@totalrow", DbType.Int32)
                                           {Direction = ParameterDirection.Output}
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_Partner_GetList", param, out comx);
            if (r != null)
            {
                list = new List<PartnerInfo>();
                while (r.Read())
                {
                    var info = new PartnerInfo();
                    if (r["Id"] != null && !r["Id"].ToString().Equals(""))
                    {
                        info.Id = Int32.Parse(r["Id"].ToString());
                    }
                    if (r["Name"] != null && !r["Name"].ToString().Equals(""))
                    {
                        info.Name = r["Name"].ToString();
                    }
                    if (r["Link"] != null && !r["Link"].ToString().Equals(""))
                    {
                        info.Link = r["Link"].ToString();
                    }
                    if (r["Description"] != null && !r["Description"].ToString().Equals(""))
                    {
                        info.Description = r["Description"].ToString();
                    }
                    if (r["Image"] != null && !r["Image"].ToString().Equals(""))
                    {
                        info.Image = r["Image"].ToString();
                    }
                    if (r["Alt"] != null && !r["Alt"].ToString().Equals(""))
                    {
                        info.Alt = r["Alt"].ToString();
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