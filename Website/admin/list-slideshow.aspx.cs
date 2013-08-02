using System;
using System.Web.UI.WebControls;
using Models.DataAccess;

namespace Website.admin
{
    public partial class list_slideshow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }

        private void LoadGrid()
        {
            GV_Album.DataSource = SliderImpl.Instance.GetAll();
            GV_Album.DataBind();
        }

        protected void GV_Album_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GV_Album.PageIndex = e.NewPageIndex;
            LoadGrid();
        }

        protected void GV_Album_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GV_Album.DataKeys[e.RowIndex].Value);
            SliderImpl.Instance.Delete(id);
            LoadGrid();
        }

        protected void GV_Album_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Response.Redirect("edit-slideshow.aspx?id=" + GV_Album.DataKeys[e.NewEditIndex].Value);
        }

        protected void Link_Add_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit-slideshow.aspx");
        }
    }
}
