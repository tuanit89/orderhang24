using System;
using System.Web.UI.WebControls;

namespace Website.admin
{
    public partial class list_settings_other : System.Web.UI.Page
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
            var lst = Models.DataAccess.SettingImpl.Instance.GetList();
            grvUser.DataSource = lst;
            grvUser.DataBind();
        }

        protected void grvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var id = grvUser.DataKeys[e.RowIndex].Value.ToString();
            Models.DataAccess.SettingImpl.Instance.Delete(id);
            BindGrid();
        }

        protected void grvUser_RowEditing(object sender, GridViewEditEventArgs e)
        {
            var id = grvUser.DataKeys[e.NewEditIndex].Value.ToString();
            Response.Redirect("edit-settings-other.aspx?id="+id);
        }

        protected void grvUser_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            grvUser.PageIndex = e.NewSelectedIndex;
            BindGrid();
        }
    }
}
