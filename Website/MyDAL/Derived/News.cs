using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SubSonic.Linq.Structure;

namespace MyDAL
{
    public partial class News
    {
        public static List<News> ListNewsByType(int top,string cateType)
        {
                var lst = new trathainguyenDB().usp_news_GetList_ByCateType(0, top, cateType).ExecuteTypedList<News>();
                return lst;
        }

       
    }

    public partial class NewsCategory
    {
        public List<News> ListNewsByType()
        {
            var lst = new trathainguyenDB().usp_news_GetList_ByCateType(0, 4, "dich-vu").ExecuteTypedList<News>();
            return lst;
        }
    }
}