using System;

namespace Website.admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack && Session["UserInfo"]!=null)
            {
                var prev = Request.QueryString["return"];
                if (string.IsNullOrEmpty(prev))
                {
                    Response.Redirect("~/admin");
                }
                Response.Redirect("~/" + Server.HtmlDecode(prev));
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            var txtuser = UserName.Text.Trim();
            var txtpass = Password.Text.Trim();
            if(string.IsNullOrEmpty(txtuser) || string.IsNullOrEmpty(txtpass))
            {
                FailureText.Text = "Tên đăng nhập hoặc mật khẩu chưa có";
                return;
            }
            var user = Models.DataAccess.UserImpl.Instance.GetLogin(txtuser, txtpass);
            if(user==null || user.Id<1)
            {
                FailureText.Text = "Sai mật khẩu hoặc tên đăng nhập không đúng!";
                return;
            }
            Session.Add("UserInfo",user);
            var prev = Request.QueryString["return"];
            if(string.IsNullOrEmpty(prev))
            {
                Response.Redirect("~/admin");
            }
            Response.Redirect("~/" + Server.HtmlDecode(prev));
        }
    }
}
