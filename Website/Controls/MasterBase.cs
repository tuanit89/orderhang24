using System.Configuration;
using System.Web;
using System.Web.UI;
using Models;

namespace tratancuonghoangbinh.Controls
{
    public class MasterBase : MasterPage
    {
        public string MetaDescription { get; set; }
        public string FacebookSnippet { get; set; }
        
        public void FacebookOpenGraph(string images)
        {
            var path = HttpContext.Current.Request.RawUrl;
            FacebookSnippet = Models.StringHelper.RichSnippet.SetFaceBookMeta(path, images, MetaDescription, Page.Header.Title);
        }
    }
}