using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;
using tuanva.Core;

namespace Models.DataAccess
{
	public class OrderImpl
    {
        private static OrderImpl _OrderImpl;
        public static OrderImpl Instance
        {
            get { return _OrderImpl ?? (_OrderImpl = new OrderImpl()); }
        }

        public int Add(OrderInfo info)
        {
			SqlParameter[] param = {
			    new SqlParameter("@CustomerID", info.CustomerID),
			new SqlParameter("@FullnameOrder", info.FullnameOrder),
			new SqlParameter("@SexOrder", info.SexOrder),
			new SqlParameter("@AddressOrder", info.AddressOrder),
			new SqlParameter("@EmailOrder", info.EmailOrder),
			new SqlParameter("@PhoneOrder", info.PhoneOrder),
			new SqlParameter("@MobileOrder", info.MobileOrder),
			new SqlParameter("@FaxOrder", info.FaxOrder),
			new SqlParameter("@OtherInfoOrder", info.OtherInfoOrder),
			new SqlParameter("@FullnameReceived", info.FullnameReceived),
			new SqlParameter("@SexReceived", info.SexReceived),
			new SqlParameter("@AddressReceived", info.AddressReceived),
			new SqlParameter("@EmailReceived", info.EmailReceived),
			new SqlParameter("@PhoneReceived", info.PhoneReceived),
			new SqlParameter("@MobileReceived", info.MobileReceived),
			new SqlParameter("@FaxReceived", info.FaxReceived),
			new SqlParameter("@OtherInfoReceived", info.OtherInfoReceived),
			new SqlParameter("@Shipping", info.Shipping),
			new SqlParameter("@TransitTime", info.TransitTime),
			new SqlParameter("@Payment", info.Payment),
			new SqlParameter("@TotalPayment", info.TotalPayment),
			new SqlParameter("@ProductNumber", info.ProductNumber),
			new SqlParameter("@StatusOrder", info.StatusOrder),
			new SqlParameter("@OnOrder", info.OnOrder)			
		   };
            return int.Parse(DataHelper.ExecuteScalar(Config.ConnectString, "usp_Order_Add", param).ToString());           
        }
        
        public int Update(OrderInfo info)
        {
			SqlParameter[] param = {
									   new SqlParameter("@OrderID", info.OrderID)
			                            ,new SqlParameter("@CustomerID", info.CustomerID),
			                            new SqlParameter("@FullnameOrder", info.FullnameOrder),
			                            new SqlParameter("@SexOrder", info.SexOrder),
			                            new SqlParameter("@AddressOrder", info.AddressOrder),
			                            new SqlParameter("@EmailOrder", info.EmailOrder),
			                            new SqlParameter("@PhoneOrder", info.PhoneOrder),
			                            new SqlParameter("@MobileOrder", info.MobileOrder),
			                            new SqlParameter("@FaxOrder", info.FaxOrder),
			                            new SqlParameter("@OtherInfoOrder", info.OtherInfoOrder),
			                            new SqlParameter("@FullnameReceived", info.FullnameReceived),
			                            new SqlParameter("@SexReceived", info.SexReceived),
			                            new SqlParameter("@AddressReceived", info.AddressReceived),
			                            new SqlParameter("@EmailReceived", info.EmailReceived),
			                            new SqlParameter("@PhoneReceived", info.PhoneReceived),
			                            new SqlParameter("@MobileReceived", info.MobileReceived),
			                            new SqlParameter("@FaxReceived", info.FaxReceived),
			                            new SqlParameter("@OtherInfoReceived", info.OtherInfoReceived),
			                            new SqlParameter("@Shipping", info.Shipping),
			                            new SqlParameter("@TransitTime", info.TransitTime),
			                            new SqlParameter("@Payment", info.Payment),
			                            new SqlParameter("@TotalPayment", info.TotalPayment),
			                            new SqlParameter("@ProductNumber", info.ProductNumber),
			                            new SqlParameter("@StatusOrder", info.StatusOrder),
			                            new SqlParameter("@OnOrder", info.OnOrder)			
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_Order_Update", param);    
        }

        public int UpdateStatus(int OrderID, int StatusOrder)
        {
            SqlParameter[] param = {
									   new SqlParameter("@OrderID", OrderID),
			                           new SqlParameter("@StatusOrder", StatusOrder)		
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_Order_UpdateStatus", param);
        }

        public int Delete(int id)
        {
            SqlParameter[] param = {
									   new SqlParameter("@OrderID", id)
			
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_Order_Delete", param);   
        }

        public OrderInfo GetInfo(int id)
        {
            OrderInfo info = null;
			SqlParameter[] param = {
									   new SqlParameter("@OrderID", id)
			
								   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_Order_GetById", param);
			if (r != null)
			{
				info = new OrderInfo();
				while (r.Read())
				{
					info.OrderID = Int32.Parse(r["OrderID"].ToString());
			info.CustomerID = Int32.Parse(r["CustomerID"].ToString());
			info.FullnameOrder = r["FullnameOrder"].ToString();
			info.SexOrder = Int32.Parse(r["SexOrder"].ToString());
			info.AddressOrder = r["AddressOrder"].ToString();
			info.EmailOrder = r["EmailOrder"].ToString();
			info.PhoneOrder = r["PhoneOrder"].ToString();
			info.MobileOrder = r["MobileOrder"].ToString();
			info.FaxOrder = r["FaxOrder"].ToString();
			info.OtherInfoOrder = r["OtherInfoOrder"].ToString();
			info.FullnameReceived = r["FullnameReceived"].ToString();
			info.SexReceived = Int32.Parse(r["SexReceived"].ToString());
			info.AddressReceived = r["AddressReceived"].ToString();
			info.EmailReceived = r["EmailReceived"].ToString();
			info.PhoneReceived = r["PhoneReceived"].ToString();
			info.MobileReceived = r["MobileReceived"].ToString();
			info.FaxReceived = r["FaxReceived"].ToString();
			info.OtherInfoReceived = r["OtherInfoReceived"].ToString();
			info.Shipping = Int32.Parse(r["Shipping"].ToString());
			info.TransitTime = r["TransitTime"].ToString();
			info.Payment = Int32.Parse(r["Payment"].ToString());
			info.TotalPayment = Int32.Parse(r["TotalPayment"].ToString());
			info.ProductNumber = Int32.Parse(r["ProductNumber"].ToString());
			info.StatusOrder = Int32.Parse(r["StatusOrder"].ToString());
			info.OnOrder = Convert.ToDateTime(r["OnOrder"]);
			
				}
				r.Close();
                r.Dispose();
			}
			return info;
        }

        public List<OrderInfo> GetList(int pageIndex, int pageSize, out int total)
        {
            List<OrderInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output}
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_Order_GetList", param, out comx);
            if (r != null)
            {
                list = new List<OrderInfo>();
                while (r.Read())
                {
					var info = new OrderInfo();
                    info.OrderID = Int32.Parse(r["OrderID"].ToString());
			        info.CustomerID = Int32.Parse(r["CustomerID"].ToString());
			        info.FullnameOrder = r["FullnameOrder"].ToString();
			        info.SexOrder = Int32.Parse(r["SexOrder"].ToString());
			        info.AddressOrder = r["AddressOrder"].ToString();
			        info.EmailOrder = r["EmailOrder"].ToString();
			        info.PhoneOrder = r["PhoneOrder"].ToString();
			        info.MobileOrder = r["MobileOrder"].ToString();
			        info.FaxOrder = r["FaxOrder"].ToString();
			        info.OtherInfoOrder = r["OtherInfoOrder"].ToString();
			        info.FullnameReceived = r["FullnameReceived"].ToString();
			        info.SexReceived = Int32.Parse(r["SexReceived"].ToString());
			        info.AddressReceived = r["AddressReceived"].ToString();
			        info.EmailReceived = r["EmailReceived"].ToString();
			        info.PhoneReceived = r["PhoneReceived"].ToString();
			        info.MobileReceived = r["MobileReceived"].ToString();
			        info.FaxReceived = r["FaxReceived"].ToString();
			        info.OtherInfoReceived = r["OtherInfoReceived"].ToString();
			        info.Shipping = Int32.Parse(r["Shipping"].ToString());
			        info.TransitTime = r["TransitTime"].ToString();
			        info.Payment = Int32.Parse(r["Payment"].ToString());
			        info.TotalPayment = Int32.Parse(r["TotalPayment"].ToString());
			        info.ProductNumber = Int32.Parse(r["ProductNumber"].ToString());
			        info.StatusOrder = Int32.Parse(r["StatusOrder"].ToString());
			        info.OnOrder = Convert.ToDateTime(r["OnOrder"]);
					
                    list.Add(info);
                }
                r.Close();
                r.Dispose();
                t = int.Parse(comx.Parameters[2].Value.ToString());
            }

            total = t;
            return list;
        }

        public List<OrderInfo> GetAll(int Status,out int total)
        {
            List<OrderInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@StatusOrder",Status),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output}
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_Order_GetAll", param, out comx);
            if (r != null)
            {
                list = new List<OrderInfo>();
                while (r.Read())
                {
                    var info = new OrderInfo();
                    info.OrderID = Int32.Parse(r["OrderID"].ToString());
                    info.CustomerID = Int32.Parse(r["CustomerID"].ToString());
                    info.FullnameOrder = r["FullnameOrder"].ToString();
                    info.SexOrder = Int32.Parse(r["SexOrder"].ToString());
                    info.AddressOrder = r["AddressOrder"].ToString();
                    info.EmailOrder = r["EmailOrder"].ToString();
                    info.PhoneOrder = r["PhoneOrder"].ToString();
                    info.MobileOrder = r["MobileOrder"].ToString();
                    info.FaxOrder = r["FaxOrder"].ToString();
                    info.OtherInfoOrder = r["OtherInfoOrder"].ToString();
                    info.FullnameReceived = r["FullnameReceived"].ToString();
                    info.SexReceived = Int32.Parse(r["SexReceived"].ToString());
                    info.AddressReceived = r["AddressReceived"].ToString();
                    info.EmailReceived = r["EmailReceived"].ToString();
                    info.PhoneReceived = r["PhoneReceived"].ToString();
                    info.MobileReceived = r["MobileReceived"].ToString();
                    info.FaxReceived = r["FaxReceived"].ToString();
                    info.OtherInfoReceived = r["OtherInfoReceived"].ToString();
                    info.Shipping = Int32.Parse(r["Shipping"].ToString());
                    info.TransitTime = r["TransitTime"].ToString();
                    info.Payment = Int32.Parse(r["Payment"].ToString());
                    info.TotalPayment = Int32.Parse(r["TotalPayment"].ToString());
                    info.ProductNumber = Int32.Parse(r["ProductNumber"].ToString());
                    info.StatusOrder = Int32.Parse(r["StatusOrder"].ToString());
                    info.OnOrder = Convert.ToDateTime(r["OnOrder"]);

                    list.Add(info);
                }
                r.Close();
                r.Dispose();
                t = int.Parse(comx.Parameters[1].Value.ToString());
            }

            total = t;
            return list;
        }
    }
}
