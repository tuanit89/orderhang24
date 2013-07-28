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
                var lst = new trathainguyenDB().usp_news_GetList_ByCateType(0, top, 0, cateType).ExecuteTypedList<News>();
                return lst;
        }
    }
}