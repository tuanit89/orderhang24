using System;
using System.Web.UI.WebControls;
using Models.DataAccess;
using MyDAL;

namespace Website.admin
{
    public partial class list_reviews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            var lstReviews = CustomerReview.All();
            grvUser.DataSource = lstReviews;
            grvUser.DataBind();
        }

        protected void grvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(grvUser.DataKeys[e.RowIndex].Value.ToString());
            BoxAdImpl.Instance.Delete(id);
            BindGrid();
        }

        protected void grvUser_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(grvUser.DataKeys[e.NewEditIndex].Value.ToString());
            Response.Redirect("edit-reviews.aspx?id=" + id);
        }

        protected void grvUser_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            grvUser.PageIndex = e.NewSelectedIndex;
            BindGrid();
        }

        protected void drpLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
