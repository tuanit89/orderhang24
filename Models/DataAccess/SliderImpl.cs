using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models.Entity;
using tuanva.Core;

namespace Models.DataAccess
{
    public class SliderImpl
    {
        private static SliderImpl _SliderImpl;
        public static SliderImpl Instance
        {
            get { return _SliderImpl ?? (_SliderImpl = new SliderImpl()); }
        }

        public int Add(SliderInfo info)
        {
            SqlParameter[] param = {
			    new SqlParameter("@name", info.name),
			new SqlParameter("@image", info.image),
			new SqlParameter("@alt", info.alt),
			new SqlParameter("@link", info.link)			
		   };
            return int.Parse(DataHelper.ExecuteScalar(Config.ConnectString, "usp_Slider_Add", param).ToString());
        }

        public int Update(SliderInfo info)
        {
            SqlParameter[] param = {
									   new SqlParameter("@id", info.id)
			,new SqlParameter("@name", info.name),
			new SqlParameter("@image", info.image),
			new SqlParameter("@alt", info.alt),
			new SqlParameter("@link", info.link)			
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_Slider_Update", param);
        }


        public int Delete(int id)
        {
            SqlParameter[] param = {
									   new SqlParameter("@id", id)
			
								   };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_Slider_Delete", param);
        }

        public SliderInfo GetInfo(int id)
        {
            SliderInfo info = null;
            SqlParameter[] param = {
									   new SqlParameter("@id", id)
			
								   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_Slider_GetById", param);
            if (r != null)
            {
                info = new SliderInfo();
                while (r.Read())
                {
                    info.id = Int32.Parse(r["id"].ToString());
                    info.name = r["name"].ToString();
                    info.image = r["image"].ToString();
                    info.alt = r["alt"].ToString();
                    info.link = r["link"].ToString();

                }
                r.Close();
                r.Dispose();
            }
            return info;
        }

        public List<SliderInfo> GetList(int pageIndex, int pageSize, out int total)
        {
            List<SliderInfo> list = null;
            var t = 0;
            SqlParameter[] param = {
                                       new SqlParameter("@pageIndex",pageIndex),
                                       new SqlParameter("@pageSize",pageSize),
                                       new SqlParameter("@totalrow",DbType.Int32){Direction = ParameterDirection.Output}
                                   };
            SqlCommand comx;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_Slider_GetList", param, out comx);
            if (r != null)
            {
                list = new List<SliderInfo>();
                while (r.Read())
                {
                    var info = new SliderInfo();
                    info.id = Int32.Parse(r["id"].ToString());
                    info.name = r["name"].ToString();
                    info.image = r["image"].ToString();
                    info.alt = r["alt"].ToString();
                    info.link = r["link"].ToString();


                    list.Add(info);
                }
                r.Close();
                r.Dispose();
                t = int.Parse(comx.Parameters[2].Value.ToString());
            }

            total = t;
            return list;
        }

        public List<SliderInfo> GetAll()
        {
            List<SliderInfo> list = null;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_slider_GetAll", null);
            if (r != null)
            {
                list = new List<SliderInfo>();
                while (r.Read())
                {
                    var info = new SliderInfo();
                    info.id = Int32.Parse(r["id"].ToString());
                    info.name = r["name"].ToString();
                    info.image = r["image"].ToString();
                    info.alt = r["alt"].ToString();
                    info.link = r["link"].ToString();

                    list.Add(info);
                }
                r.Close();
                r.Dispose();
            }
            return list;
        }
    }
}
