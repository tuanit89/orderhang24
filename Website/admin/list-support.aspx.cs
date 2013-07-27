using System;
using System.Web.UI.WebControls;

namespace Website.admin
{
    public partial class list_support : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            var lstSupport = Models.DataAccess.SupportImpl.Instance.GetList();
            grvUser.DataSource = lstSupport;
            grvUser.DataBind();
        }

        protected void grvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(grvUser.DataKeys[e.RowIndex].Value.ToString());
            Models.DataAccess.SupportImpl.Instance.Delete(id);
            BindGrid();
        }

        protected void grvUser_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(grvUser.DataKeys[e.NewEditIndex].Value.ToString());
            Response.Redirect("edit-support.aspx?id="+id);
        }
    }
}
