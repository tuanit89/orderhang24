using System;
using Models.DataAccess;
using Models.Entity;

namespace Website.admin
{
    public partial class edit_user : System.Web.UI.Page
    {
        protected static bool IsEdit;
        protected void Page_Load(object sender, EventArgs e)
        {
            if((Session["UserInfo"] as UserInfo).Status!=1) Response.Redirect("~/admin");
            if(!IsPostBack)
            {
                if(!string.IsNullOrEmpty(Request.QueryString["Id"]))
                    BindUser();
            }
        }

        private void BindUser()
        {
            var id = int.Parse(Request.QueryString["Id"]);
            var user = UserImpl.Instance.GetInfo(id);
            if(user==null) Response.Redirect("~/admin/");
            txtUsername.Text = user.Username;
            txtPassword.Text = user.Password;
            txtFullname.Text = user.Fullname;
            checkAdmin.Checked = user.Status == 1;
            IsEdit = true;
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if(IsEdit)
            {
                if (EditUser())
                {
                    Response.Redirect("list-user.aspx");
                }
            }
            else
            {
                if (AddNewUser())
                {
                    Response.Redirect("list-user.aspx");
                }
            }
        }

        private bool AddNewUser()
        {
            if (txtUsername.Text.Length < 1 || txtFullname.Text.Length < 1 || txtPassword.Text.Length < 1)
            {
                ltrThongbao.Text = "Bạn cần nhập đủ thông tin vào các ô!";
                return false;
            }
            var user = new UserInfo();
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.Fullname = txtFullname.Text;
            user.Status = Convert.ToInt16(checkAdmin.Checked ? 1 : 0);
            UserImpl.Instance.Add(user);
            return true;
        }

        private bool EditUser()
        {
            if (txtUsername.Text.Length < 1 || txtFullname.Text.Length < 1)
            {
                ltrThongbao.Text = "Bạn cần nhập đủ thông tin vào các ô!";
                return false;
            }
            var id = int.Parse(Request.QueryString["Id"]);
            var user = UserImpl.Instance.GetInfo(id);
            user.Username = txtUsername.Text;
            if (!string.IsNullOrEmpty(txtPassword.Text)) user.Password = txtPassword.Text;
            user.Fullname = txtFullname.Text;
            user.Status = Convert.ToInt16(checkAdmin.Checked ? 1 : 0);
            UserImpl.Instance.Update(user);
            return true;
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                if (EditUser()) Response.Redirect("edit-user.aspx");
            }
            else
            {
                if (AddNewUser())
                {
                    Response.Redirect("edit-user.aspx");
                }
            }
        }
    }
}
