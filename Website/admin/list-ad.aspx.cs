using System;
using System.Web.UI.WebControls;
using Models.DataAccess;

namespace Website.admin
{
    public partial class list_ad : System.Web.UI.Page
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
            var drp = (BoxAdImpl.Location)Enum.Parse(typeof(BoxAdImpl.Location),drpLocation.SelectedValue);
            var lstSupport = BoxAdImpl.Instance.GetList(drp);
            grvUser.DataSource = lstSupport;
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
            Response.Redirect("edit-ad.aspx?id=" + id);
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
