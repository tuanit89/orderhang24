using System;
using System.IO;
using System.Web.Caching;
using Models.DataAccess;
using Models.Entity;
using Models.StringHelper;

namespace Website
{
    public partial class contact : System.Web.UI.Page
    {
        protected string BreadCump;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.Count > 0)
            {
                Response.Clear();
                var fullname = Request.Form["fullname"];
                var email = Request.Form["email"];
                var phone = Request.Form["phone"];
                var subject = Request.Form["subject"];
                var message = Request.Form["message"];
                var info = new ContactInfo();
                info.FullName = fullname;
                info.Email = email;
                info.Phone = phone;
                info.Subject = subject;
                info.Message = message;
                var rowcount = ContactImpl.Instance.Add(info);
                Response.Write(rowcount);
                Response.End();
                return;
            }

            BreadCump += RichSnippet.SetBreadCumps("/", "Trang chủ", true);
            BreadCump += RichSnippet.SetBreadCumps("/lien-he.htm", "Liên hệ", false);
        }

        protected string ContactString
        {
            get
            {
                if (Cache.Get("cache_ContactUs") == null)
                {
                    var strR = new StreamReader(Server.MapPath("~/html/contact.htm"));
                    var str = strR.ReadToEnd();
                    strR.Close();
                    Cache.Insert("cache_ContactUs", str, new CacheDependency(Server.MapPath("~/html/contact.htm")));
                    return str;
                }
                return Cache.Get("cache_ContactUs").ToString();
            }
        }
    }
}