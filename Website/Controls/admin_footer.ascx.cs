using System;
using System.Globalization;

namespace tratancuonghoangbinh.Controls
{
    public partial class admin_footer : System.Web.UI.UserControl
    {
        protected string Month;
        protected const string Name = "Vũ Anh Tuấn - SĐT 0985.032.797";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Month = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}