using System;
using Models.Entity;

namespace tratancuonghoangbinh.Controls
{
    public partial class admin_header : System.Web.UI.UserControl
    {
        protected string Username { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = Session["UserInfo"] as UserInfo;
            if (user != null)
            {
                Username = user.Fullname;
            }
    }
    }
}