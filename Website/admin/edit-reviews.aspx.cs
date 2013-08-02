using System;
using System.IO;
using Models.Entity;
using MyDAL;
using tuanva.Core;

namespace Website.admin
{
    public partial class edit_reviews : System.Web.UI.Page
    {
        protected bool IsEdit;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                IsEdit = true;
            }
            if (!IsPostBack && !string.IsNullOrEmpty(Request.QueryString["id"]) && ConvertUtility.ToInt16(Request.QueryString["id"]) > 0) BindSupport();
        }
        

        protected void BindSupport()
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]) || ConvertUtility.ToInt16(Request.QueryString["id"]) == 0)
            {
                Response.Redirect("edit-reviews.aspx", true);
            }
            var info = CustomerReview.SingleOrDefault(a=>a.Id ==int.Parse(Request.QueryString["id"]));
            if (info == null || info.Id == 0)
            {
                Response.Redirect("edit-reviews.aspx", true);
                return;
            }
            txtCustomerName.Text = info.CustomerName;
            txtReviews.Text = info.CustomerComment;
            txtDienThoai.Text = info.Email;
            txtDiaChi.Text = info.Address;
        }

        bool AddOrUpdate()
        {
            var info = CustomerReview.SingleOrDefault(a=>a.Id==int.Parse(Request.QueryString["id"]));
            if (info == null || info.Id == 0)
            {
                Response.Redirect("edit-reviews.aspx", true);
                return false;
            }
            info.CustomerName = txtCustomerName.Text;
            info.CustomerComment = txtReviews.Text.Trim();
            info.Address = txtDiaChi.Text;
            info.Email = txtDienThoai.Text;
            return true;
        }

        protected void InsertAndNew_Click(object sender, EventArgs e)
        {
            if (AddOrUpdate())
            {
                Response.Redirect("edit-reviews.aspx", true);
            }
        }

        protected void InsertAndBack_Click(object sender, EventArgs e)
        {
            if (AddOrUpdate())
            {
                Response.Redirect("list-reviews.aspx", true);
            }
        }
    }
}