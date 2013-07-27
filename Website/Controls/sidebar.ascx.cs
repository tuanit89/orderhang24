using System;
using System.Linq;
using System.Text;
using Models.DataAccess;
using Models.Entity;
using Models.StringHelper;

namespace tratancuonghoangbinh.Controls
{
    public partial class sidebar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string BindMenu()
        {
            var sb = new StringBuilder();
            var lst = Models.DataAccess.ProductCategoryImpl.Instance.GetAll();
            if (lst == null || lst.Count == 0) return string.Empty;
            var lv = lst.Where(item => item.ParentId == 0);
            foreach (var infoParent in lv)
            {
                sb.Append("<li><h3><a href=\"" + infoParent.Link + "\">" + infoParent.Name + "</a></h3>");
                ProductCategoryInfo parent = infoParent;
                var lv1 = lst.Where(item => item.ParentId == parent.Id).ToList();
                if (lv1.Any())
                {
                    sb.Append("<ul>");
                    foreach (var infoChild in lv1)
                    {
                        sb.Append("<li><h3><a href=\""+infoChild.Link+"\">"+infoChild.Name+"</a></h3></li>");
                    }
                    sb.Append("</ul>");
                }
                sb.Append("</li>");
            }
            return sb.ToString();
        }

        protected string BindSupport()
        {
            var lst = Models.DataAccess.SupportImpl.Instance.GetList();
            if(lst==null  || lst.Count==0) return string.Empty;
            var sb = new StringBuilder();
            foreach (var item in lst)
            {
                sb.AppendFormat("<div class=\"yahoo-support-items\">" +
                                "<div class=\"yahoo-support-items-left\">" +
                                "<p>{0}</p>" +
                                "<p class=\"hotline\">Hotline : {1}</p></div>" +
                                "<div class=\"yahoo-support-items-right\">" +
                                "<a href=\"ymsgr:sendIM?{2}\" class=\"yahoo\">" +
                                "<img src=\"http://opi.yahoo.com/online?u={2}&amp;m=g&amp;t=1\" alt=\"Liên hệ với {0} qua Yahoo\" /></a>" +
                                "<a href=\"skype:{3}?call\" class=\"skype\">" +
                                "<img src=\"/Content/Images/skype.png\" alt=\"Liên hệ với {0} qua Skype\" />" +
                                "</a>" +
                                "</div>" +
                                "</div>",item.Name,item.Phone,item.Yahoo,item.Skype);
            }
            return sb.ToString();
        }

        protected string BindVideo()
        {
            return Models.DataAccess.SettingImpl.Instance.GetByKey("home-video").Value;
        }

        protected string BindAd
        {
            get
            {
                var lst = BoxAdImpl.Instance.GetList(BoxAdImpl.Location.ad);
                if (lst == null || lst.Count == 0) return string.Empty;
                var sb = new StringBuilder();
                foreach (var adInfo in lst)
                {
                    sb.AppendFormat("<li>" +
                                    "<a href=\"{0}\" class=\"img-partner\">" +
                                    "<img src=\"{1}\" alt=\"{3}\" /></a>" +
                                    "<h4>{2}</h4>" +
                                    "</li>", adInfo.Link, "/ImageHandler.ashx?width=204&image=/images/ad/" + adInfo.Image, adInfo.Name,adInfo.Description);
                }
                return sb.ToString();
            }
        }

        protected string BindMenuNews()
        {
            var sb = new StringBuilder();
            var lst = Models.DataAccess.NewsCategoryImpl.Instance.GetAll("tin-tuc");
            if (lst == null || lst.Count == 0) return string.Empty;
            var lv = lst.Where(item => item.ParentId == 0);
            foreach (var infoParent in lv)
            {
                sb.Append("<li><h3><a href=\"" + infoParent.Link + "\">" + infoParent.Name + "</a></h3>");
                sb.Append("</li>");
            }
            return sb.ToString();
        }

        protected string ListMostViewestNews
        {
            get 
            { 
                var lst = NewsImpl.Instance.GetListMostViewset();
                if (lst == null || lst.Count == 0) return string.Empty;
                var sb = new StringBuilder();
                foreach (var newsInfo in lst)
                {
                    sb.AppendFormat("<li>" +
                                    "<h4 class=\"title\"><a href=\"{0}\">{1}</a></h4>" +
                                    "<a href=\"{0}\"><img src=\"{2}\" alt=\"{3}\"></a>" +
                                    "<p class=\"consulting_content\">{4}</p>" +
                                    "<div class=\"details\"><a href=\"{0}\">Chi tiết »</a>" +
                                    "</div>" +
                                    "</li>", newsInfo.Link, newsInfo.Title,
                                    "/ImageHandler.ashx?width=84&image=/images/news/" + newsInfo.Id/1000 + "/" +
                                    newsInfo.Id + "/" + newsInfo.Image, newsInfo.AltImage, newsInfo.Description.CutWordByLength(85));
                }
                return sb.ToString();
            }
        }
         
        protected string TagsList
        {
            get { 
                var lstTags = TagsImpl.GetListTags();
                if (lstTags == null || lstTags.Count == 0) return string.Empty;
                var sb = new StringBuilder();
                foreach (var tag in lstTags)
                {
                    sb.AppendFormat(@"<a href=""/tags/{0}.aspx"">{1}</a> | ", tag.Replace(' ','-'), tag);
                }
                return sb.ToString(0,sb.Length-2);
            }
        }
    }
}