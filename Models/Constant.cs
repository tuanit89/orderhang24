using System.Configuration;
using System.IO;
using System.Web;
using System.Web.UI.WebControls;

namespace tuanva.Core
{
    public class Constant
    {
        // Connection String
        internal const string LIC_LOGISTICS_CONNECTION_STRING = "sunlawConnectionString";

        //Session name
        public const string SessionNameAccountAdmin = "AccountAdmin";

        public const string QueryLanguages = "QUERY_LANG";

        public const string LANGUAGE_DEFAULT = "vi-VN";

        public const string SESSION_KEY_LANGUAGE = "SESSION_KEY_LANGUAGE";
        public const string SESSION_KEY_CART = "SESSION_KEY_CART";
        public const string SESSION_KEY_USER = "SESSION_KEY_USER";
        public static string PAGESite = ConfigurationManager.AppSettings["domain"];
    }
}
