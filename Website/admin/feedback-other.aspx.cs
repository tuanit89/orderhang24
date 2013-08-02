using System;
using System.Web.UI.WebControls;
using tuanva.Core;

namespace Website.admin
{
    public partial class feedback_other : System.Web.UI.Page
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
            var lst = Models.DataAccess.ContactImpl.Instance.GetList();
            grvContact.DataSource = lst;
            grvContact.DataBind();
        }

        protected void grvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(grvContact.DataKeys[e.RowIndex].Value.ToString());
            Models.DataAccess.ContactImpl.Instance.Delete(id);
            BindGrid();
        }

        protected void grvUser_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            grvContact.PageIndex = e.NewSelectedIndex;
            BindGrid();
        }
    }
}
