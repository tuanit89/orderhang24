using System;
using tuanva.Core;

namespace dongphucdangcap.com.admin
{
    public partial class list_chatbox_other: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) BindGrid();
        }

        private void BindGrid()
        {
            var type = ConvertUtility.ToByte(drpType.SelectedValue,0);
            var datasource = uniform.Impl.ContactImpl.Instant.GetList(type);
            grvUser.DataSource = datasource;
            grvUser.DataBind();
        }

        protected void grvUser_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(grvUser.DataKeys[e.RowIndex].Value);
            uniform.Impl.ContactImpl.Instant.Delete(id);
            BindGrid();
        }

        protected void drpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
