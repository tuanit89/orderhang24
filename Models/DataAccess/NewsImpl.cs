using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;
using tuanva.Core;

namespace Models.DataAccess
{
	public class NewsImpl
    {
        private static NewsImpl _newsImpl;
        public static NewsImpl Instance
        {
            get { return _newsImpl ?? (_newsImpl = new NewsImpl()); }
        }

        public int Add(NewsInfo info)
        {
			SqlParameter[] param = {
			                        new SqlParameter("@CateId", info.CateId),
			                        new SqlParameter("@Title", info.Title),
			                        new SqlParameter("@Description", info.Description),
			                        new SqlParameter("@Content", info.Content),
			                        new SqlParameter("@Image", info.Image),
			                        new SqlParameter("@AltImage", info.AltImage),
			                        new SqlParameter("@CreateDate", info.CreateDate),
			                        new SqlParameter("@Link", info.Link),
			                        new SqlParameter("@MetaDescription", info.MetaDescription),
			                        new SqlParameter("@IsAttach", info.IsAttach),
                                    new SqlParameter("@Sort",info.Sort),
                                    new SqlParameter("@Tags",info.Tags) 
		   };
           return int.Parse(DataHelper.ExecuteScalar(Config.ConnectString, "usp_News_Add", param).ToString());           
        }
        
        public int Update(NewsInfo info)
        {
			SqlParameter[] param = {
									   new SqlParameter("@Id", info.Id),
                                       new SqlParameter("@CateId", info.CateId),
			                           new SqlParameter("@Title", info.Title),
			                           new SqlParameter("@Description", info.Description),
			                           new SqlParameter("@Content", info.Content),
			                           new SqlParameter("@Image", info.Image),
			                           new SqlParameter("@AltImage", info.AltImage),
			                           new SqlParameter("@CreateDate", info.CreateDate),
			                           new SqlParameter("@Link", info.Link),
			                           new SqlParameter("@MetaDescription", info.MetaDescription),
			                           new SqlParameter("@IsAttach", info.IsAttach),
                                       new SqlParameter("@Sort",info.Sort),
                                       new SqlParameter("Tags",info.Tags) 
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_News_Update", param);    
        }


        public int Delete(int id)
        {
            SqlParameter[] param = {
									   new SqlParameter("@Id", id)
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_News_Delete", param);   
        }

        public NewsInfo GetInfo(int id)
        {
            NewsInfo info = null;
			SqlParameter[] param = {
									   new SqlParameter("@Id", id)
			
								   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_News_GetById", param);
			if (r != null)
			{
				info = new NewsInfo();
				while (r.Read())
				{
					info.Id = Int32.Parse(r["Id"].ToString());
			        info.CateId = Int32.Parse(r["CateId"].ToString());
			        info.Title = r["Title"].ToString();
			        info.Description = r["Description"].ToString();
			        info.Content = r["Content"].ToString();
			        info.Image = r["Image"].ToString();
			        info.AltImage = r["AltImage"].ToString();
			        info.CreateDate = Convert.ToDateTime(r["CreateDate"]);
			        info.Link = r["Link"].ToString();
			        info.MetaDescription = r["MetaDescription"].ToString();
			        info.IsAttach = bool.Parse(r["IsAttach"].ToString());
				    info.Sort = int.Parse(r["Sort"].ToString());
				    info.Tags = r["Tags"].ToString();
				    info.PageVisitor = ConvertUtility.ToInt32(r["PageView"]);
				}
				r.Close();
                r.Dispose();
			}
			return info;
        }

        public List<NewsInfo> GetList(int pageIndex, int pageSize, out int total, int CateId)
        {
            List<NewsInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output},
                                       new SqlParameter("@CateId",CateId) 
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_news_GetList", param, out comx);
            if (r != null)
            {
                list = new List<NewsInfo>();
                while (r.Read())
                {
                    var info = new NewsInfo();
                    info.Id = Int32.Parse(r["Id"].ToString());
                    info.CateId = Int32.Parse(r["CateId"].ToString());
                    info.Title = r["Title"].ToString();
                    info.Description = r["Description"].ToString();
                    info.Content = r["Content"].ToString();
                    info.Image = r["Image"].ToString();
                    info.AltImage = r["AltImage"].ToString();
                    info.CreateDate = Convert.ToDateTime(r["CreateDate"]);
                    info.Link = r["Link"].ToString();
                    info.MetaDescription = r["MetaDescription"].ToString();
                    info.IsAttach = bool.Parse(r["IsAttach"].ToString());
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
                t = int.Parse(comx.Parameters[2].Value.ToString());
            }
            total = t;
            return list;
        }

        public List<NewsInfo> GetListHome()
        {
            List<NewsInfo> list = null;
            
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_news_GetList_HOME", null);
            if (r != null)
            {
                list = new List<NewsInfo>();
                while (r.Read())
                {
                    var info = new NewsInfo();
                    info.Id = Int32.Parse(r["Id"].ToString());
                    info.Title = r["Title"].ToString();
                    info.Description = r["Description"].ToString();
                    info.Image = r["Image"].ToString();
                    info.AltImage = r["AltImage"].ToString();
                    info.Link = r["Link"].ToString();
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
            }
            return list;
        }

        public List<NewsInfo> GetList(int pageIndex, int pageSize, out int total, string cateType)
        {
            List<NewsInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output},
                                       new SqlParameter("@cateType",cateType) 
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_news_GetList_ByCateType", param, out comx);
            if (r != null)
            {
                list = new List<NewsInfo>();
                while (r.Read())
                {
                    var info = new NewsInfo();
                    info.Id = Int32.Parse(r["Id"].ToString());
                    info.CateId = Int32.Parse(r["CateId"].ToString());
                    info.Title = r["Title"].ToString();
                    info.Description = r["Description"].ToString();
                    info.Content = r["Content"].ToString();
                    info.Image = r["Image"].ToString();
                    info.AltImage = r["AltImage"].ToString();
                    info.CreateDate = Convert.ToDateTime(r["CreateDate"]);
                    info.Link = r["Link"].ToString();
                    info.MetaDescription = r["MetaDescription"].ToString();
                    info.IsAttach = bool.Parse(r["IsAttach"].ToString());
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
                t = int.Parse(comx.Parameters[2].Value.ToString());
            }
            total = t;
            return list;
        }

        public NewsInfo Get1Info(string cateType)
        {
            NewsInfo info = null;
            SqlParameter[] param = {
                                       new SqlParameter("@cateType", cateType)

                                   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_News_GetByCateType", param);
            if (r != null)
            {
                info = new NewsInfo();
                while (r.Read())
                {
                    info.Id = Int32.Parse(r["Id"].ToString());
                    info.CateId = Int32.Parse(r["CateId"].ToString());
                    info.Title = r["Title"].ToString();
                    info.Description = r["Description"].ToString();
                    info.Content = r["Content"].ToString();
                    info.Image = r["Image"].ToString();
                    info.AltImage = r["AltImage"].ToString();
                    info.CreateDate = Convert.ToDateTime(r["CreateDate"]);
                    info.Link = r["Link"].ToString();
                    info.MetaDescription = r["MetaDescription"].ToString();
                    info.IsAttach = bool.Parse(r["IsAttach"].ToString());
                    info.Sort = int.Parse(r["Sort"].ToString());
                    info.Tags = r["Tags"].ToString();
                }
                r.Close();
                r.Dispose();
            }
            return info;
        }

        public List<NewsInfo> GetListRelate(int currentId, int currentCate)
        {
            List<NewsInfo> list = null;
            var param = new[]
                            {
                                new SqlParameter("@CateId", currentCate),
                                new SqlParameter("@Id", currentId)
                            };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_news_GetList_Relate", param);
            if (r != null)
            {
                list = new List<NewsInfo>();
                while (r.Read())
                {
                    var info = new NewsInfo();
                    //info.Id = Int32.Parse(r["Id"].ToString());
                   // info.CateId = Int32.Parse(r["CateId"].ToString());
                    info.Title = r["Title"].ToString();
                    //info.Description = r["Description"].ToString();
                    //info.Content = r["Content"].ToString();
                    info.Image = r["Image"].ToString();
                    //info.AltImage = r["AltImage"].ToString();
                    //info.CreateDate = Convert.ToDateTime(r["CreateDate"]);
                    info.Link = r["Link"].ToString();
                    //info.MetaDescription = r["MetaDescription"].ToString();
                    //info.IsAttach = bool.Parse(r["IsAttach"].ToString());
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
            }
            return list;
        }

        public List<NewsInfo> GetListNewsByWeek(int currentId, int currentCate)
        {
            List<NewsInfo> list = null;
            var param = new[]
                            {
                                new SqlParameter("@CateId", currentCate),
                                new SqlParameter("@Id", currentId)
                            };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_news_GetList_Newest", param);
            if (r != null)
            {
                list = new List<NewsInfo>();
                while (r.Read())
                {
                    var info = new NewsInfo();
                    //info.Id = Int32.Parse(r["Id"].ToString());
                    // info.CateId = Int32.Parse(r["CateId"].ToString());
                    info.Title = r["Title"].ToString();
                    //info.Description = r["Description"].ToString();
                    //info.Content = r["Content"].ToString();
                    info.Image = r["Image"].ToString();
                    //info.AltImage = r["AltImage"].ToString();
                    //info.CreateDate = Convert.ToDateTime(r["CreateDate"]);
                    info.Link = r["Link"].ToString();
                    //info.MetaDescription = r["MetaDescription"].ToString();
                    //info.IsAttach = bool.Parse(r["IsAttach"].ToString());
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
            }
            return list;
        }

        public void AddPageView(int id)
        {
            var param = new[]
                {
                    new SqlParameter("@id", id)
                };
            DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_news_AddPageView", param);
        }

        public List<NewsInfo> GetListMostViewset()
        {
            List<NewsInfo> list = null;

            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_news_GetList_Viewest", null);
            if (r != null)
            {
                list = new List<NewsInfo>();
                while (r.Read())
                {
                    var info = new NewsInfo();
                    info.Id = Int32.Parse(r["Id"].ToString());
                    info.Title = r["Title"].ToString();
                    info.Description = r["Description"].ToString();
                    info.Image = r["Image"].ToString();
                    info.AltImage = r["AltImage"].ToString();
                    info.Link = r["Link"].ToString();
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
            }
            return list;
        }

        public List<NewsInfo> GetListByTags(int pageIndex, int pageSize, out int total, string tagsName)
        {
            List<NewsInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output},
                                       new SqlParameter("@tag",tagsName) 
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_news_GetListByTag", param, out comx);
            if (r != null)
            {
                list = new List<NewsInfo>();
                while (r.Read())
                {
                    var info = new NewsInfo();
                    info.Id = Int32.Parse(r["Id"].ToString());
                    info.Title = r["Title"].ToString();
                    info.Description = r["Description"].ToString();
                    info.Image = r["Image"].ToString();
                    info.AltImage = r["AltImage"].ToString();
                    info.CreateDate = Convert.ToDateTime(r["CreateDate"]);
                    info.Link = r["Link"].ToString();
                    info.MetaDescription = r["MetaDescription"].ToString();
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
