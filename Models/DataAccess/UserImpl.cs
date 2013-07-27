using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;

namespace Models.DataAccess
{
    public class UserImpl
    {
        private static UserImpl _userImpl;
        public static UserImpl Instance
        {
            get { return _userImpl ?? (_userImpl = new UserImpl()); }
        }

        #region IUser Members
        public int Add(UserInfo info)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@Username", info.Username),
                                       new SqlParameter("@Password", info.Password),
                                       new SqlParameter("@Fullname", info.Fullname),
                                       new SqlParameter("@Status", info.Status)
                                   };
            return int.Parse(DataHelper.ExecuteScalar(Config.ConnectString, "tuan_User_Add", param).ToString());
        }

        public UserInfo GetLogin(string username, string password)
        {
            UserInfo info = null;
            var param = new[]
                            {
                                new SqlParameter("@username", username),
                                new SqlParameter("@password", password)
                            };
            var connect = new SqlConnection(Config.ConnectString);
            var cmd = new SqlCommand("tuan_user_login", connect);
            cmd.Parameters.AddRange(param);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                info = new UserInfo();
                while (r.Read())
                {
                    if (r["Id"] != null && !r["Id"].ToString().Equals(""))
                    {
                        info.Id = int.Parse(r["Id"].ToString());
                    }
                    if (r["Username"] != null && !r["Username"].ToString().Equals(""))
                    {
                        info.Username = r["Username"].ToString();
                    }
                    if (r["Password"] != null && !r["Password"].ToString().Equals(""))
                    {
                        info.Password = r["Password"].ToString();
                    }
                    if (r["Fullname"] != null && !r["Fullname"].ToString().Equals(""))
                    {
                        info.Fullname = r["Fullname"].ToString();
                    }
                    if (r["Status"] != null && !r["Status"].ToString().Equals(""))
                    {
                        info.Status = Convert.ToInt16(r["Status"].ToString());
                    }
                }
                cmd.Dispose();
                connect.Close();
                connect.Dispose();
            }
            return info;
        }

        public int Update(UserInfo info)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@Id", info.Id),
                                       new SqlParameter("@Username", info.Username),
                                       new SqlParameter("@Password", info.Password),
                                       new SqlParameter("@Fullname", info.Fullname),
                                       new SqlParameter("@Status", info.Status)
                                   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "tuan_tblUser_Update", param);
        }

        public UserInfo UpdateProfile(UserInfo infos)
        {
            UserInfo info = null;
            SqlParameter[] param = {
                                       new SqlParameter("@Id", infos.Id),
                                       new SqlParameter("@Username", infos.Username),
                                       new SqlParameter("@Password", infos.Password),
                                       new SqlParameter("@Fullname", infos.Fullname)
                                   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "tuan_user_UpdateProfile", param);
            if (r != null)
            {
                info = new UserInfo();
                while (r.Read())
                {
                    if (r["Id"] != null && !r["Id"].ToString().Equals(""))
                    {
                        info.Id = int.Parse(r["Id"].ToString());
                    }
                    if (r["Username"] != null && !r["Username"].ToString().Equals(""))
                    {
                        info.Username = r["Username"].ToString();
                    }
                    if (r["Password"] != null && !r["Password"].ToString().Equals(""))
                    {
                        info.Password = r["Password"].ToString();
                    }
                    if (r["Fullname"] != null && !r["Fullname"].ToString().Equals(""))
                    {
                        info.Fullname = r["Fullname"].ToString();
                    }
                    if (r["Status"] != null && !r["Status"].ToString().Equals(""))
                    {
                        info.Status = Convert.ToInt16(r["Status"].ToString());
                    }
                }
            }
            return info;
        }


        public int Delete(int id)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@id", id)
                                   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "tuan_tblUser_Delete", param);
        }

        public UserInfo GetInfo(int id)
        {
            UserInfo info = null;
            SqlParameter[] param = {
                                       new SqlParameter("@id", id)
                                   };
            IDataReader r = DataHelper.ExecuteReader(Config.ConnectString, "tuan_User_GetById", param);
            if (r != null)
            {
                info = new UserInfo();
                while (r.Read())
                {
                    if (r["Id"] != null && !r["Id"].ToString().Equals(""))
                    {
                        info.Id = int.Parse(r["Id"].ToString());
                    }
                    if (r["Username"] != null && !r["Username"].ToString().Equals(""))
                    {
                        info.Username = r["Username"].ToString();
                    }
                    if (r["Password"] != null && !r["Password"].ToString().Equals(""))
                    {
                        info.Password = r["Password"].ToString();
                    }
                    if (r["Fullname"] != null && !r["Fullname"].ToString().Equals(""))
                    {
                        info.Fullname = r["Fullname"].ToString();
                    }
                    if (r["Status"] != null && !r["Status"].ToString().Equals(""))
                    {
                        info.Status = Convert.ToInt16(r["Status"].ToString());
                    }
                }
                r.Close();
                r.Dispose();
            }
            return info;
        }

        public List<UserInfo> GetList()
        {
            List<UserInfo> list = null;
            IDataReader r = DataHelper.ExecuteReader(Config.ConnectString, "tuan_tblUser_GetList_All", null);
            if (r != null)
            {
                list = new List<UserInfo>();
                while (r.Read())
                {
                    var info = new UserInfo();
                    if (r["Id"] != null && !r["Id"].ToString().Equals(""))
                    {
                        info.Id = Int32.Parse(r["Id"].ToString());
                    }
                    if (r["Username"] != null && !r["Username"].ToString().Equals(""))
                    {
                        info.Username = r["Username"].ToString();
                    }
                    if (r["Password"] != null && !r["Password"].ToString().Equals(""))
                    {
                        info.Password = r["Password"].ToString();
                    }
                    if (r["Fullname"] != null && !r["Fullname"].ToString().Equals(""))
                    {
                        info.Fullname = r["Fullname"].ToString();
                    }
                    if (r["Status"] != null && !r["Status"].ToString().Equals(""))
                    {
                        info.Status = Convert.ToInt16(r["Status"].ToString());
                    }
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
            }
            return list;
        }

        public List<UserInfo> GetList(int pageIndex, int pageSize, out int total)
        {
            List<UserInfo> list = null;
            int t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex", pageIndex),
                                       new SqlParameter("@pageSize", pageSize),
                                       new SqlParameter("@totalrow", DbType.Int32)
                                           {Direction = ParameterDirection.Output}
                                   };
            SqlCommand comx;
            IDataReader r = DataHelper.ExecuteReader(Config.ConnectString, "usp_tblUser_GetList", param, out comx);
            if (r != null)
            {
                list = new List<UserInfo>();
                while (r.Read())
                {
                    var info = new UserInfo();
                    if (r["Id"] != null && !r["Id"].ToString().Equals(""))
                    {
                        info.Id = Int32.Parse(r["Id"].ToString());
                    }
                    if (r["Username"] != null && !r["Username"].ToString().Equals(""))
                    {
                        info.Username = r["Username"].ToString();
                    }
                    if (r["Password"] != null && !r["Password"].ToString().Equals(""))
                    {
                        info.Password = r["Password"].ToString();
                    }
                    if (r["Fullname"] != null && !r["Fullname"].ToString().Equals(""))
                    {
                        info.Fullname = r["Fullname"].ToString();
                    }
                    if (r["Status"] != null && !r["Status"].ToString().Equals(""))
                    {
                        info.Status = Convert.ToInt16(r["Status"].ToString());
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

        #endregion
    }
}