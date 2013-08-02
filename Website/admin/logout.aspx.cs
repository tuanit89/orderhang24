using System;

namespace dongphucdangcap.com.admin
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("~/admin/login.aspx");
        }
    }
}
