using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;

namespace Models.DataAccess
{
    public class NewsCategoryImpl
    {
        private static NewsCategoryImpl _NewsCategoryImpl;
        public static NewsCategoryImpl Instance
        {
            get { return _NewsCategoryImpl ?? (_NewsCategoryImpl = new NewsCategoryImpl()); }
        }

        public int Add(NewsCategoryInfo info)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@Name", info.Name),
                                       new SqlParameter("@Link", info.Link),
                                       new SqlParameter("@Sort", info.Sort),
                                       new SqlParameter("@Description", info.Description),
                                       new SqlParameter("@MetaDescription", info.MetaDescription),
                                       new SqlParameter("@ParentId", info.ParentId),
                                       new SqlParameter("@CateType", info.CateType)
                                   };
            return int.Parse(DataHelper.ExecuteScalar(Config.ConnectString, "usp_NewsCategory_Add", param).ToString());
        }

        public int Update(NewsCategoryInfo info)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@Id", info.Id)
                                       , new SqlParameter("@Name", info.Name),
                                       new SqlParameter("@Link", info.Link),
                                       new SqlParameter("@Sort", info.Sort),
                                       new SqlParameter("@Description", info.Description),
                                       new SqlParameter("@MetaDescription", info.MetaDescription),
                                       new SqlParameter("@ParentId", info.ParentId),
                                       new SqlParameter("@CateType", info.CateType)
                                   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_NewsCategory_Update", param);
        }


        public int Delete(int id)
        {
            SqlParameter[] param = {
									   new SqlParameter("@Id", id)
			
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_NewsCategory_Delete", param);
        }

        public NewsCategoryInfo GetInfo(int id)
        {
            NewsCategoryInfo info = null;
            SqlParameter[] param = {
									   new SqlParameter("@Id", id)
			
								   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_NewsCategory_GetById", param);
            if (r != null)
            {
                info = new NewsCategoryInfo();
                while (r.Read())
                {
                    info.Id = Int32.Parse(r["Id"].ToString());
                    info.Name = r["Name"].ToString();
                    info.Link = r["Link"].ToString();
                    info.Sort = Int32.Parse(r["Sort"].ToString());
                    info.Description = r["Description"].ToString();
                    info.MetaDescription = r["MetaDescription"].ToString();
                    info.ParentId = Int32.Parse(r["ParentId"].ToString());
                    info.CateType = r["CateType"].ToString();
                }
                r.Close();
                r.Dispose();
            }
            return info;
        }

        public List<NewsCategoryInfo> GetList(int pageIndex, int pageSize, out int total)
        {
            List<NewsCategoryInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output}
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_NewsCategory_GetList", param, out comx);
            if (r != null)
            {
                list = new List<NewsCategoryInfo>();
                while (r.Read())
                {
                    var info = new NewsCategoryInfo();
                    info.Id = Int32.Parse(r["Id"].ToString());
                    info.Name = r["Name"].ToString();
                    info.Link = r["Link"].ToString();
                    info.Sort = Int32.Parse(r["Sort"].ToString());
                    info.Description = r["Description"].ToString();
                    info.MetaDescription = r["MetaDescription"].ToString();
                    info.ParentId = Int32.Parse(r["ParentId"].ToString());


                    list.Add(info);
                }
                r.Close();
                r.Dispose();
                t = int.Parse(comx.Parameters[2].Value.ToString());
            }

            total = t;
            return list;
        }

        public List<NewsCategoryInfo> GetAll(string cateType)
        {
            List<NewsCategoryInfo> list = null;
            SqlParameter[] param = {
                                       new SqlParameter("@CateType",cateType)
                                   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_NewsCategory_GetAll", param);
            if (r != null)
            {
                list = new List<NewsCategoryInfo>();
                while (r.Read())
                {
                    var info = new NewsCategoryInfo();
                    info.Id = Int32.Parse(r["Id"].ToString());
                    info.Name = r["Name"].ToString();
                    info.Link = r["Link"].ToString();
                    info.Sort = Int32.Parse(r["Sort"].ToString());
                    info.Description = r["Description"].ToString();
                    info.MetaDescription = r["MetaDescription"].ToString();

                    list.Add(info);
                }
                r.Close();
                r.Dispose();
            }
            return list;
        }

        public int UpdateSort(int id, int sort)
        {
            var param = new[]
                            {
                                new SqlParameter("@id", id),
                                new SqlParameter("@sort",sort)
                            };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "tuan_newstype_updateSort", param);
        }
    }
}
