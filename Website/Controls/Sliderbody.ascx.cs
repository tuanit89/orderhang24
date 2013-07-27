using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tratancuonghoangbinh.Controls
{
    public partial class Sliderbody : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string Sliders
        {
            get
            {
                var model = Models.DataAccess.SliderImpl.Instance.GetAll();
                if (model == null || model.Count == 0) return string.Empty;
                var sb =new StringBuilder();
                sb.Append("<div class=\"sliders-wrap\">");
                sb.Append("<div id=\"coin-slide\">");
                foreach (var sliderInfo in model)
                {
                    sb.AppendFormat("<a href=\"{0}\" title=\"{1}\"><img src=\"/Images/slider/{2}\" alt=\"{1}\" /></a>",
                        sliderInfo.link,sliderInfo.alt,sliderInfo.image);
                }
                sb.Append("</div></div>");
                return sb.ToString();
            }
        }
    }
}