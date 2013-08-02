using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;
using tuanva.Core;

namespace Models.DataAccess
{
    public class OrderDetailImpl
    {
        private static OrderDetailImpl _OrderDetailImpl;
        public static OrderDetailImpl Instance
        {
            get { return _OrderDetailImpl ?? (_OrderDetailImpl = new OrderDetailImpl()); }
        }

        public int Add(OrderDetailInfo info)
        {
            SqlParameter[] param = {
		                                new SqlParameter("@OrderId", info.OrderId),
		                                new SqlParameter("@ProductId", info.ProductId),
		                                new SqlParameter("@ProductName", info.ProductName),
		                                new SqlParameter("@price", info.price),
		                                new SqlParameter("@Number", info.Number),
                                        new SqlParameter("@size", info.size)
		                            };
            return int.Parse(DataHelper.ExecuteScalar(Config.ConnectString, "usp_OrderDetail_Add", param).ToString());
        }

        public int Update(OrderDetailInfo info)
        {
            SqlParameter[] param = {
									   new SqlParameter("@id", info.id),
                                       new SqlParameter("@OrderId", info.OrderId),
			                           new SqlParameter("@ProductId", info.ProductId),
			                           new SqlParameter("@ProductName", info.ProductName),
			                           new SqlParameter("@price", info.price),
			                           new SqlParameter("@Number", info.Number),
                                       new SqlParameter("@size", info.size)
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_OrderDetail_Update", param);
        }


        public int Delete(int id)
        {
            SqlParameter[] param = {
									   new SqlParameter("@id", id)			
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_OrderDetail_Delete", param);
        }

        public OrderDetailInfo GetInfo(int id)
        {
            OrderDetailInfo info = null;
            SqlParameter[] param = {
									   new SqlParameter("@id", id)			
								   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_OrderDetail_GetById", param);
            if (r != null)
            {
                info = new OrderDetailInfo();
                while (r.Read())
                {
                    info.id = Int32.Parse(r["id"].ToString());
                    info.OrderId = Int32.Parse(r["OrderId"].ToString());
                    info.ProductId = Int32.Parse(r["ProductId"].ToString());
                    info.ProductName = r["ProductName"].ToString();
                    info.price = Int32.Parse(r["price"].ToString());
                    info.Number = Int32.Parse(r["Number"].ToString());
                    info.size = r["size"].ToString();
                }
                r.Close();
                r.Dispose();
            }
            return info;
        }

        public List<OrderDetailInfo> GetList(int OrderId, int pageIndex, int pageSize, out int total)
        {
            List<OrderDetailInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@OrderId",OrderId),
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output}
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_OrderDetail_GetList", param, out comx);
            if (r != null)
            {
                list = new List<OrderDetailInfo>();
                while (r.Read())
                {
                    var info = new OrderDetailInfo();
                    info.id = Int32.Parse(r["id"].ToString());
                    info.OrderId = Int32.Parse(r["OrderId"].ToString());
                    info.ProductId = Int32.Parse(r["ProductId"].ToString());
                    info.ProductName = r["ProductName"].ToString();
                    info.price = Int32.Parse(r["price"].ToString());
                    info.Number = Int32.Parse(r["Number"].ToString());
                    info.size = r["size"].ToString();

                    list.Add(info);
                }
                r.Close();
                r.Dispose();
                t = int.Parse(comx.Parameters[3].Value.ToString());
            }

            total = t;
            return list;
        }

        public List<OrderDetailInfo> GetAll(int OrderId, out int total)
        {
            List<OrderDetailInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@OrderId",OrderId),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output}
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_OrderDetail_GetAll", param, out comx);
            if (r != null)
            {
                list = new List<OrderDetailInfo>();
                while (r.Read())
                {
                    var info = new OrderDetailInfo();
                    info.id = Int32.Parse(r["id"].ToString());
                    info.OrderId = Int32.Parse(r["OrderId"].ToString());
                    info.ProductId = Int32.Parse(r["ProductId"].ToString());
                    info.ProductName = r["ProductName"].ToString();
                    info.price = Int32.Parse(r["price"].ToString());
                    info.Number = Int32.Parse(r["Number"].ToString());
                    info.size = r["size"].ToString();

                    list.Add(info);
                }
                r.Close();
                r.Dispose();
                t = int.Parse(comx.Parameters[1].Value.ToString());
            }
            total = t;
            return list;
        }

        public void AddItemsOnOrder(List<OrderDetailInfo> lst)
        {
            foreach (var info in lst)
            {
                Add(info);
            }
        }
    }
}
