using System;
using System.Text;
using Models.DataAccess;

namespace tratancuonghoangbinh.Controls
{
    public partial class SliderFooter : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string ListSlide
        {
            get
            {
                var lstAd = BoxAdImpl.Instance.GetList(BoxAdImpl.Location.partner);
                if (lstAd == null || lstAd.Count == 0) return string.Empty;
                var sb = new StringBuilder();
                foreach (var info in lstAd)
                {
                    sb.AppendFormat("<li>" +
                                    "<a href=\"{0}\" rel=\"nofollow\">" +
                                    "<img height=\"100\" src=\"/ImageHandler.ashx?width=148&height=100&image=/images/partner/{1}\" alt=\"{2}\" /></a></li>",
                                    info.Link, info.Image, info.Description);
                }
                return sb.ToString();
            }
        }
    }
}