using System.Collections.Generic;
using System.Configuration;

namespace Models.StringHelper
{
    public class RichSnippet
    {
        private static string FbAdmins {
            get { return ConfigurationManager.AppSettings["fbadmins"]; }
        }
        private static string OgSiteName {
            get { return ConfigurationManager.AppSettings["fbsitename"]; }
        }
        private static string DefaultImage {
            get { return ConfigurationManager.AppSettings["defaultImage"]; }
        }

        /// <summary>
        /// Thiết lập 1 breadcump
        /// </summary>
        /// <param name="link"></param>
        /// <param name="name"></param>
        /// <param name="hasCump">Show > hay không?</param>
        /// <returns></returns>
        public static string SetBreadCumps(string link,string name,bool hasCump)
        {//<a href="#">Trang chủ</a> » <a href="#">Sản phẩm</a> » <a href="#">Chè thái nguyên</a>
            return string.Format("<span itemscope itemtype=\"http://data-vocabulary.org/Breadcrumb\" class=\"rs-breadcump\">" +
                                 "<a href=\"{0}\" itemprop=\"url\"><span itemprop=\"title\">{1}</span></a>{2}" +
                                 "</span>",link, name, hasCump ? " › " : "");
        }
        /// <summary>
        /// Set Meta friendly cho facebook
        /// </summary>
        /// <param name="url"></param>
        /// <param name="image"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static string SetFaceBookMeta(string url,string image,string description,string title)
        {
            return string.Format("\n<meta property=\"og:type\" content=\"website\" /> \n" +
                                 "<meta property=\"og:site_name\" content=\"{0}\" /> \n" +
                                 "<meta property=\"og:title\" content=\"{1}\" /> \n" +
                                 "<meta property=\"og:description\" content=\"{2}\" /> \n" +
                                 "<meta property=\"og:image\" content=\"{3}\" /> \n" +
                                 "<meta property=\"og:url\" content=\"{4}\" /> \n" +
                                 "<meta property=\"fb:admins\" content=\"{5}\" />",
                                 OgSiteName, string.IsNullOrEmpty(title)?OgSiteName:title, description, string.IsNullOrEmpty(image) ? DefaultImage:Config.SiteRoot + image, Config.SiteRoot + url, FbAdmins);
        }
    }
}
