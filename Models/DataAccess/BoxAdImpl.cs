using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;

namespace Models.DataAccess
{
    public class BoxAdImpl
    {
        private static BoxAdImpl _ad;
        public enum Location
        {
            ad, partner, bodyhome
        }
        public static BoxAdImpl Instance
        {
            get { return _ad ?? (_ad = new BoxAdImpl()); }
        }
        public int Add(BoxAdInfo info)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@Name", info.Name),
                                       new SqlParameter("@Description", info.Description),
                                       new SqlParameter("@Link", info.Link),
                                       new SqlParameter("@Image", info.Image),
                                       new SqlParameter("@Sort", info.Sort),
                                       new SqlParameter("@Location",info.Location)
                                       
                                   };
            return int.Parse(DataHelper.ExecuteScalar(Config.ConnectString, "usp_BoxAd_Add", param).ToString());
        }

        public int Update(BoxAdInfo info)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@Id", info.Id)
                                       , new SqlParameter("@Name", info.Name),
                                       new SqlParameter("@Description", info.Description),
                                       new SqlParameter("@Link", info.Link),
                                       new SqlParameter("@Image", info.Image),
                                       new SqlParameter("@Sort", info.Sort),
                                       new SqlParameter("@Location", info.Location)
                                   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_BoxAd_Update", param);
        }


        public int Delete(int id)
        {
            SqlParameter[] param = {
									   new SqlParameter("@Id", id)
			
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_BoxAd_Delete", param);
        }

        public BoxAdInfo GetInfo(int id)
        {
            BoxAdInfo info = null;
            SqlParameter[] param = {
									   new SqlParameter("@Id", id)
			
								   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_BoxAd_GetById", param);
            if (r != null)
            {
                info = new BoxAdInfo();
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
                    if (r["Description"] != null && !r["Description"].ToString().Equals(""))
                    {
                        info.Description = r["Description"].ToString();
                    }
                    if (r["Link"] != null && !r["Link"].ToString().Equals(""))
                    {
                        info.Link = r["Link"].ToString();
                    }
                    if (r["Image"] != null && !r["Image"].ToString().Equals(""))
                    {
                        info.Image = r["Image"].ToString();
                    }
                    if (r["Sort"] != null && !r["Sort"].ToString().Equals(""))
                    {
                        info.Sort = Int32.Parse(r["Sort"].ToString());
                    }
                    if (r["Location"] != null && !r["Location"].ToString().Equals(""))
                    {
                        info.Location = r["Location"].ToString();
                    }

                }
                r.Close();
                r.Dispose();
            }
            return info;
        }

        public List<BoxAdInfo> GetList(Location location)
        {
            List<BoxAdInfo> list = null;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_BoxAd_GetList_All", new[]{new SqlParameter("@location",location.ToString()) });
            if (r != null)
            {
                list = new List<BoxAdInfo>();
                while (r.Read())
                {
                    var info = new BoxAdInfo();
                    if (r["Id"] != null && !r["Id"].ToString().Equals(""))
                    {
                        info.Id = Int32.Parse(r["Id"].ToString());
                    }
                    if (r["Name"] != null && !r["Name"].ToString().Equals(""))
                    {
                        info.Name = r["Name"].ToString();
                    }
                    if (r["Description"] != null && !r["Description"].ToString().Equals(""))
                    {
                        info.Description = r["Description"].ToString();
                    }
                    if (r["Link"] != null && !r["Link"].ToString().Equals(""))
                    {
                        info.Link = r["Link"].ToString();
                    }
                    if (r["Image"] != null && !r["Image"].ToString().Equals(""))
                    {
                        info.Image = r["Image"].ToString();
                    }
                    if (r["Sort"] != null && !r["Sort"].ToString().Equals(""))
                    {
                        info.Sort = Int32.Parse(r["Sort"].ToString());
                    }
                    if (r["Location"] != null && !r["Location"].ToString().Equals(""))
                    {
                        info.Location = r["Location"].ToString();
                    }
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
            }

            return list;
        }

        public List<BoxAdInfo> GetList(int pageIndex, int pageSize, out int total)
        {
            List<BoxAdInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output}
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_BoxAd_GetList", param, out comx);
            if (r != null)
            {
                list = new List<BoxAdInfo>();
                while (r.Read())
                {
                    var info = new BoxAdInfo();
                    if (r["Id"] != null && !r["Id"].ToString().Equals(""))
                    {
                        info.Id = Int32.Parse(r["Id"].ToString());
                    }
                    if (r["Name"] != null && !r["Name"].ToString().Equals(""))
                    {
                        info.Name = r["Name"].ToString();
                    }
                    if (r["Description"] != null && !r["Description"].ToString().Equals(""))
                    {
                        info.Description = r["Description"].ToString();
                    }
                    if (r["Link"] != null && !r["Link"].ToString().Equals(""))
                    {
                        info.Link = r["Link"].ToString();
                    }
                    if (r["Image"] != null && !r["Image"].ToString().Equals(""))
                    {
                        info.Image = r["Image"].ToString();
                    }
                    if (r["Sort"] != null && !r["Sort"].ToString().Equals(""))
                    {
                        info.Sort = Int32.Parse(r["Sort"].ToString());
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
