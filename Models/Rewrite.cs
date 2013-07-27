using System.Text.RegularExpressions;
using tuanva.Core;

namespace Models
{
    public static class Rewrite
    {
        public static string GenCategory(string cateName,int idCate)
        {
            return "/"+ UnicodeUtility.UrlRewriting(cateName).RemoveDuplicate("-cn\\d+") + "-cn" + idCate + ".aspx";
        }

        public static string GenCategoryProduct(string cateName, int idCate)
        {
            return "/" + UnicodeUtility.UrlRewriting(cateName).RemoveDuplicate("-cp\\d+") + "-cp" + idCate + ".aspx";
        }

        public static string GenCategorySupplier(string cateName, int idCate)
        {
            return "/" + UnicodeUtility.UrlRewriting(cateName).RemoveDuplicate("-cs\\d+") + "-cs" + idCate + ".aspx";
        }

        public static string GenDetail(string cateName, int idCate, int idDetail, string nameDetail)
        {
            // /tu-van-c2/dong-phuc-dep-d8.html
            return string.Format("/{0}/{1}-{2}.aspx",UnicodeUtility.UrlRewriting(cateName),UnicodeUtility.UrlRewriting(nameDetail),"c"+idCate+"d"+idDetail);
        }

        public static string GenDetailProduct(string cateName, int idCate, int idDetail, string nameDetail)
        {
            // /tu-van-c2/dong-phuc-dep-d8.html
            return string.Format("/{0}/{1}-{2}.aspx", UnicodeUtility.UrlRewriting(cateName), UnicodeUtility.UrlRewriting(nameDetail), "c" + idCate + "p" + idDetail);
        }

        private static string RemoveDuplicate(this string chuoi,string pattern)
        {
            // -c43 => --43 cai-co-c476552228 -c54.htm
            var regex = new Regex(pattern); // -c\d+
            return regex.Replace(chuoi, "-");
        }
    }
}
