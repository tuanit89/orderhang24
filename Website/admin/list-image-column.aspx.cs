using System;
using System.Linq;
using Models.DataAccess;
using Models.Entity;
using MyDAL;

namespace Website.admin
{
    public partial class list_image_column : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = Session["UserInfo"] as UserInfo;
            if(user.Status!=1)
            {
                Response.Redirect("default.aspx");
                return;
            }
            if(!IsPostBack) BindGrid();
        }

        private void BindGrid()
        {
            var location = drpKhoi.SelectedValue;
            var lstColumns = ImageColumn.Find(c => c.LocationType == location.ToLower()).OrderBy(a=>a.Sort).ToList();
            grvUser.DataSource = lstColumns;
            grvUser.DataBind();
        }

        protected void grvUser_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            Response.Redirect("edit-image-column.aspx?id=" + grvUser.DataKeys[e.NewEditIndex].Value);
        }

        protected void grvUser_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(grvUser.DataKeys[e.RowIndex].Value);
            ImageColumn.Delete(c=>c.Id ==id);
            BindGrid();
        }

        protected void drpKhuvuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(drpKhoi.SelectedIndex==0) return;
            BindGrid();
        }
    }
}
