using System;
using System.Collections.Generic;
using System.Configuration;

namespace Models
{
    public class Config
    {
        private static string _connectionString;

        public static string ConnectString
        {
            get
            {
                if(string.IsNullOrEmpty(_connectionString)) _connectionString= Encrypt.Encrypt.DecryptConn(ConfigurationManager.AppSettings["conStr"]);
                return _connectionString;
                //return @"Server=.\sqlexpress;Database=dongphuc-new;Trusted_Connection=True;";
                //return @"Server=.;Database=trathainguyen;Trusted_Connection=True;";
            }
        }
        private static string _ImgPathShow;
        public static string ImgPathShow
        {
            get { 
                if(string.IsNullOrEmpty(_ImgPathShow))
                    _ImgPathShow = ConfigurationManager.AppSettings["ImgPathShow"];
                return _ImgPathShow;
            }

        }

        private static string _ServerSolr;
        public static string ServerSolr
        {
            get
            {
                if (string.IsNullOrEmpty(_ServerSolr))
                    _ServerSolr = ConfigurationManager.AppSettings["ServerSolr"];
                return _ServerSolr;
            }

        }

        public static string LogPath
        {
            get { return ConfigurationManager.AppSettings["LogPath"]; }
        }

        public static string PathAdmin
        {
            get { return ConfigurationManager.AppSettings["PathAdmin"]; }
        }

        public static string LoginAdmin
        {
            get { return ConfigurationManager.AppSettings["LoginAdmin"]; }
        }

        public static string PathNotRight
        {
            get { return ConfigurationManager.AppSettings["PathNotRight"]; }
        }

        public static string PathError
        {
            get { return ConfigurationManager.AppSettings["PathError"]; }
        }

        private static int _RecordPerPage;
        public static int RecordPerPage
        {
            get
            {
                _RecordPerPage = int.TryParse(ConfigurationManager.AppSettings["PageSizeAdmin"], out _RecordPerPage) ? int.Parse(ConfigurationManager.AppSettings["PageSizeAdmin"]) : 40;

                return _RecordPerPage;
            }
        }

        public static string PathUpload
        {
            get { return ConfigurationManager.AppSettings["PathUpload"]; }
        }

        public static string HtmlFolder
        {
            get { return ConfigurationManager.AppSettings["HtmlFolder"]; }
        }

        public static string CacheLink
        {
            get { return ConfigurationManager.AppSettings["CacheLink"]; }
        }

        public static string AdminFolder
        {
            get { return ConfigurationManager.AppSettings["AdminFolder"]; }
        }

        public static string ContactMail4
        {
            get { return ConfigurationManager.AppSettings["ContactMail4"]; }
        }

        

        //
        public static string GetPathImagePromotion
        {
            get { return Convert.ToString(ConfigurationManager.AppSettings["ImagePromotion"]); }
        }

        public static string GetPathNoImage
        {
            get { return Convert.ToString(ConfigurationManager.AppSettings["NoImage"]); }
        }

        public static string GetPathAlbum
        {
            get { return Convert.ToString(ConfigurationManager.AppSettings["ImageAlbum"]); }
        }

        public static string GetPathCategoryProduct
        {
            get { return Convert.ToString(ConfigurationManager.AppSettings["ImageCategoryProduct"]); }
        }

        public static string GetPathProduct
        {
            get { return Convert.ToString(ConfigurationManager.AppSettings["ImageProduct"]); }
        }

        public static string GetPathSlideshow
        {
            get { return Convert.ToString(ConfigurationManager.AppSettings["ImageSlideshow"]); }
        }

        public static int PageSizeNews
        {
            get { return int.Parse(ConfigurationManager.AppSettings["PageSizeNews"]); }
        }
        public static int PageSizeProduct
        {
            get { return int.Parse(ConfigurationManager.AppSettings["PageSizeProduct"]); }
        }

        public static string SiteTitle
        {
            get { return ConfigurationManager.AppSettings["siteTitle"]; }
        }

        public static string SiteRoot
        {
            get { return ConfigurationManager.AppSettings["SiteRoot"]; }
        }

        public static List<int> CateShowHome()
        {
            var str = ConfigurationManager.AppSettings["HomeShow"].Split(',');
            var lst = new List<int>();
            foreach (var s in str)
            {
                int i;
                if(int.TryParse(s,out i) && i>0)
                {
                    lst.Add(i);
                }
            }
            return lst;
        }
    }
}