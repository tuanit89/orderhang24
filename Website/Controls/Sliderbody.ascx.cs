using System;
using System.Text;

namespace Website.Controls
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
                sb.Append("<div class=\"slider\">" +
                          "<div class=\"slider-inner\">" +
                          "<div class=\"slider-news\">" +
                          "<div class=\"slider-width\">");
                foreach (var sliderInfo in model)
                {
                    sb.AppendFormat("<a href=\"{0}\" class=\"item-slider\" title=\"{1}\"><img src=\"/Images/slider/{2}\" alt=\"{1}\" /></a>",
                        sliderInfo.link, sliderInfo.alt, sliderInfo.image);
                }
                sb.Append("</div>" +
                          "</div>" +
                          "</div>" +
                          "</div>");
                
                return sb.ToString();
            }
        }
    }
}