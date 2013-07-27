using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;

namespace Models.DataAccess
{
    public class ProductImpl
    {
        private static ProductImpl _productImpl;
        public static ProductImpl Instance
        {
            get { return _productImpl ?? (_productImpl = new ProductImpl()); }
        }

        public int Add(ProductInfo info)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@CateId", info.CateId),
                                       new SqlParameter("@ProductName", info.ProductName),
                                       new SqlParameter("@description", info.Description),
                                       new SqlParameter("@tag", info.Tag),
                                       new SqlParameter("@image", info.Image),
                                       new SqlParameter("@altImage", info.AltImage),
                                       new SqlParameter("@IsHot", info.IsHot),
                                       new SqlParameter("@ShowHome", info.IsShowHome),
                                       new SqlParameter("@Price", info.Price),
                                       new SqlParameter("@Link", info.Link),
                                       new SqlParameter("@content", info.Contents),
                                       new SqlParameter("@SupplierId", info.SupplierId),
                                       new SqlParameter("@Model",info.Model)
                                   };
            return int.Parse(DataHelper.ExecuteScalar(Config.ConnectString, "usp_Product_Add", param).ToString());
        }

        public int Update(ProductInfo info)
        {
            SqlParameter[] param = {
                                       new SqlParameter("Id",info.Id), 
                                       new SqlParameter("@CateId", info.CateId),
                                       new SqlParameter("@ProductName", info.ProductName),
                                       new SqlParameter("@description", info.Description),
                                       new SqlParameter("@tag", info.Tag),
                                       new SqlParameter("@image", info.Image),
                                       new SqlParameter("@altImage", info.AltImage),
                                       new SqlParameter("@IsHot", info.IsHot),
                                       new SqlParameter("@ShowHome", info.IsShowHome),
                                       new SqlParameter("@Price", info.Price),
                                       new SqlParameter("@Link", info.Link),
                                       new SqlParameter("@content", info.Contents),
                                       new SqlParameter("@SupplierId", info.SupplierId),
                                       new SqlParameter("@Model",info.Model) 
                                   };
            return int.Parse(DataHelper.ExecuteScalar(Config.ConnectString, "usp_Product_Update", param).ToString());
        }


        public int Delete(int id)
        {
            SqlParameter[] param = {
									   new SqlParameter("@id", id)			
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_Product_Delete", param);
        }

        public ProductInfo GetInfo(int id)
        {
            ProductInfo info = null;
            SqlParameter[] param = {
									   new SqlParameter("@id", id)
			
								   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_Product_GetById", param);
            if (r != null)
            {
                info = new ProductInfo();
                while (r.Read())
                {
                    info.Id = Int32.Parse(r["id"].ToString());

                    info.CateId = Int32.Parse(r["CateId"].ToString());
                    info.Model = r["Model"].ToString();
                    info.ProductName = r["ProductName"].ToString();
                    info.Description = r["description"].ToString();
                    info.Contents = r["content"].ToString();
                    info.Tag = r["tag"].ToString();
                    info.IsShowHome = bool.Parse(r["ShowHome"].ToString());
                    info.Image = r["image"].ToString();
                    info.AltImage = r["altImage"].ToString();
                    info.IsHot = Convert.ToBoolean(r["isHot"]);
                    info.Price = double.Parse(r["Price"].ToString());
                    info.Link = r["Link"].ToString();
                    //info.SupplierId = int.Parse(r["SupplierId"].ToString());
                    //info.SupplierName = r["Name"].ToString();
                }
                r.Close();
                r.Dispose();
            }
            return info;
        }

        public List<ProductInfo> GetList(int pageIndex, int pageSize, out int total,int cpid)
        {
            List<ProductInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output},
                                       new SqlParameter("@cateid",cpid) 
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_Product_GetList", param, out comx);
            if (r != null)
            {
                list = new List<ProductInfo>();
                while (r.Read())
                {
                    var info = new ProductInfo();
                    info.Id = Int32.Parse(r["id"].ToString());

                    info.CateId = Int32.Parse(r["CateId"].ToString());
                    info.Model = r["Model"].ToString();
                    info.ProductName = r["ProductName"].ToString();
                    info.Description = r["description"].ToString();
                    info.Contents = r["content"].ToString();
                    info.Tag = r["tag"].ToString();
                    info.IsShowHome = bool.Parse(r["ShowHome"].ToString());
                    info.Image = r["image"].ToString();
                    info.AltImage = r["altImage"].ToString();
                    info.IsHot = Convert.ToBoolean(r["isHot"]);
                    info.Price = double.Parse(r["Price"].ToString());
                    info.Link = r["Link"].ToString();
                    info.SupplierId = int.Parse(r["SupplierId"].ToString());

                    list.Add(info);
                }
                r.Close();
                r.Dispose();
                t = int.Parse(comx.Parameters[2].Value.ToString());
            }

            total = t;
            return list;
        }

        public List<ProductInfo> GetListByCateSup(int pageIndex, int pageSize, out int total,int cpid)
        {
            List<ProductInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output},
                                       new SqlParameter("@cateid",cpid)
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "[usp_Product_GetListBYCATE]", param, out comx);
            if (r != null)
            {
                list = new List<ProductInfo>();
                while (r.Read())
                {
                    var info = new ProductInfo();
                    info.Id = Int32.Parse(r["id"].ToString());
                    info.ProductName = r["ProductName"].ToString();
                    info.Price = double.Parse(r["Price"].ToString());
                    info.Link = r["link"].ToString();
                    info.Image = r["image"].ToString();
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
                t = int.Parse(comx.Parameters[2].Value.ToString());
            }

            total = t;
            return list;
        }

        public List<ProductInfo> GetListRelate(int cateid, int currentid)
        {
            List<ProductInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@CateId",cateid),
                                       new SqlParameter("@Id",currentid)
                                   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_product_GETRELATE", param);
            if (r != null)
            {
                list = new List<ProductInfo>();
                while (r.Read())
                {
                    var info = new ProductInfo();
                    info.Id = Int32.Parse(r["id"].ToString());
                    info.ProductName = r["ProductName"].ToString();
                    info.Price = double.Parse(r["Price"].ToString());
                    info.Link = r["link"].ToString();
                    info.Image = r["image"].ToString();
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
            }
            return list;
        }

        public List<ProductInfo> GetListHome(int cateid)
        {
            List<ProductInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@CateId",cateid)
                                   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_product_GETHOME", param);
            if (r != null)
            {
                list = new List<ProductInfo>();
                while (r.Read())
                {
                    var info = new ProductInfo();
                    info.Id = Int32.Parse(r["id"].ToString());
                    info.ProductName = r["ProductName"].ToString();
                    info.Price = double.Parse(r["Price"].ToString());
                    info.Link = r["link"].ToString();
                    info.Image = r["image"].ToString();
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
            }
            return list;
        }

        public List<ProductInfo> GetListByHot()
        {
            List<ProductInfo> list = null;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_product_GETHOT", null);
            if (r != null)
            {
                list = new List<ProductInfo>();
                while (r.Read())
                {
                    var info = new ProductInfo();
                    info.Id = Int32.Parse(r["id"].ToString());
                    info.ProductName = r["ProductName"].ToString();
                    info.Price = double.Parse(r["Price"].ToString());
                    info.Link = r["link"].ToString();
                    info.Image = r["image"].ToString();
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
            }
            return list;
        }

        public List<ProductInfo> BySearch(string searchQuery,int pageIndex, int pageSize, out int total)
        {
            List<ProductInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output},
                                       new SqlParameter("@query",searchQuery)
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "[usp_product_Search]", param, out comx);
            if (r != null)
            {
                list = new List<ProductInfo>();
                while (r.Read())
                {
                    var info = new ProductInfo();
                    info.Id = Int32.Parse(r["id"].ToString());
                    info.ProductName = r["ProductName"].ToString();
                    info.Price = double.Parse(r["Price"].ToString());
                    info.Link = r["link"].ToString();
                    info.Image = r["image"].ToString();
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