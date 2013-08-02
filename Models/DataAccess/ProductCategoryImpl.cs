using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;
using tuanva.Core;

namespace Models.DataAccess
{
	public class ProductCategoryImpl
    {
        private static ProductCategoryImpl _ProductCategoryImpl;
        public static ProductCategoryImpl Instance
        {
            get { return _ProductCategoryImpl ?? (_ProductCategoryImpl = new ProductCategoryImpl()); }
        }

        public int Add(ProductCategoryInfo info)
        {
			SqlParameter[] param = {
			    new SqlParameter("@Name", info.Name),
			    new SqlParameter("@Link", info.Link),
			    new SqlParameter("@Sort", info.Sort),
			    new SqlParameter("@Description", info.Description),
			    new SqlParameter("@MetaDescription", info.MetaDescription),
			    new SqlParameter("@ParentId", info.ParentId),
			    new SqlParameter("@Image", info.Image)
		   };
            return int.Parse(DataHelper.ExecuteScalar(Config.ConnectString, "usp_ProductCategory_Add", param).ToString());           
        }
        
        public int Update(ProductCategoryInfo info)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@Id", info.Id)
                                       , new SqlParameter("@Name", info.Name),
                                       new SqlParameter("@Link", info.Link),
                                       new SqlParameter("@Sort", info.Sort),
                                       new SqlParameter("@Description", info.Description),
                                       new SqlParameter("@MetaDescription", info.MetaDescription),
                                       new SqlParameter("@ParentId", info.ParentId)
                                      // new SqlParameter("@Image", info.Image)
                                   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_ProductCategory_Update", param);    
        }


        public int Delete(int id)
        {
            SqlParameter[] param = {
									   new SqlParameter("@Id", id)
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_ProductCategory_Delete", param);   
        }

        public ProductCategoryInfo GetInfo(int id)
        {
            ProductCategoryInfo info = null;
			SqlParameter[] param = {
									   new SqlParameter("@Id", id)
			
								   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_ProductCategory_GetById", param);
			if (r != null)
			{
				info = new ProductCategoryInfo();
				while (r.Read())
				{
					info.Id = Int32.Parse(r["Id"].ToString());
			        info.Name = r["Name"].ToString();
			        info.Link = r["Link"].ToString();
			        info.Sort = Int32.Parse(r["Sort"].ToString());
			        info.Description = r["Description"].ToString();
			        info.MetaDescription = r["MetaDescription"].ToString();
			        info.ParentId = Int32.Parse(r["ParentId"].ToString());
			        info.Image = r["Image"].ToString();
				}
				r.Close();
                r.Dispose();
			}
			return info;
        }

        public List<ProductCategoryInfo> GetList(int pageIndex, int pageSize, out int total)
        {
            List<ProductCategoryInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output}
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_ProductCategory_GetList", param, out comx);
            if (r != null)
            {
                list = new List<ProductCategoryInfo>();
                while (r.Read())
                {
					var info = new ProductCategoryInfo();
                    info.Id = Int32.Parse(r["Id"].ToString());
			        info.Name = r["Name"].ToString();
			        info.Link = r["Link"].ToString();
			        info.Sort = Int32.Parse(r["Sort"].ToString());
			        info.Description = r["Description"].ToString();
			        info.MetaDescription = r["MetaDescription"].ToString();
			        info.ParentId = Int32.Parse(r["ParentId"].ToString());
			        info.Image = r["Image"].ToString();
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
                t = int.Parse(comx.Parameters[2].Value.ToString());
            }

            total = t;
            return list;
        }

        public List<ProductCategoryInfo> GetListByParent(int ParentId)
        {
            List<ProductCategoryInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@ParentId",ParentId)
                                   };
            //SqlCommand comx;
            //var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_ProductCategory_GetList", param, out comx);
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_ProductCategory_GetListByParent", param);
            if (r != null)
            {
                list = new List<ProductCategoryInfo>();
                while (r.Read())
                {
                    var info = new ProductCategoryInfo();
                    info.Id = Int32.Parse(r["Id"].ToString());
                    info.Name = r["Name"].ToString();
                    info.Link = r["Link"].ToString();
                    info.Sort = Int32.Parse(r["Sort"].ToString());
                    info.Description = r["Description"].ToString();
                    info.MetaDescription = r["MetaDescription"].ToString();
                    info.ParentId = Int32.Parse(r["ParentId"].ToString());
                    info.Image = r["Image"].ToString();

                    list.Add(info);
                }
                r.Close();
                r.Dispose();
                //t = int.Parse(comx.Parameters[2].Value.ToString());
            }

            //total = t;
            return list;
        }

        public List<ProductCategoryInfo> GetAll()
        {
            List<ProductCategoryInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output}
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_ProductCategory_GetAll", param, out comx);
            if (r != null)
            {
                list = new List<ProductCategoryInfo>();
                while (r.Read())
                {
                    var info = new ProductCategoryInfo();
                    info.Id = Int32.Parse(r["Id"].ToString());
                    info.Name = r["Name"].ToString();
                    info.Link = r["Link"].ToString();
                    info.Sort = Int32.Parse(r["Sort"].ToString());
                    info.Description = r["Description"].ToString();
                    info.MetaDescription = r["MetaDescription"].ToString();
                    info.ParentId = Int32.Parse(r["ParentId"].ToString());
                    info.Image = r["Image"].ToString();

                    list.Add(info);
                }
                r.Close();
                r.Dispose();
            }
            return list;
        }
    }
}
