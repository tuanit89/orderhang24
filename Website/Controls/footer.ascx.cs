using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tratancuonghoangbinh.Controls
{
    public partial class footer : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string BindCustomFooter()
        {
            var cache = Cache["master_footer"];
            if(cache!=null)
            {
                return cache.ToString();
            }
            var info = new StreamReader(Server.MapPath("/html/footer.htm"));
            var ret = info.ReadToEnd();
            info.Close();
            info.Dispose();
            Cache.Insert("master_footer", ret, new CacheDependency(Server.MapPath("/html/footer.htm")),DateTime.Now.AddHours(1),Cache.NoSlidingExpiration);
            return ret;
        }
    }
}