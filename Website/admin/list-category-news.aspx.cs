using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Website.admin
{
    public partial class list_category_news : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDrop();
                BindGrid();
            }
        }

        private void BindDrop()
        {
            var dt = Models.DataAccess.CateTypeImpl.GetList();
            drpCateType.DataSource = dt;
            drpCateType.DataTextField = "CateTypeName";
            drpCateType.DataValueField = "CateType";
            drpCateType.DataBind();
            drpCateType.Items.Insert(0,new ListItem("[- Tất cả -]","all"));
        }

        private void BindGrid()
        {
            var datasource = Models.DataAccess.NewsCategoryImpl.Instance.GetAll(drpCateType.SelectedValue);
            
            if(datasource.Count>0)
            {
                datasource = datasource.OrderBy(a => a.Sort).ToList();
            }
            grvUser.DataSource = datasource;
            grvUser.DataBind();
        }

        protected void grvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var key = int.Parse(grvUser.DataKeys[e.RowIndex].Value.ToString());
            Models.DataAccess.NewsCategoryImpl.Instance.Delete(key);
            BindGrid();
        }

        protected void grvUser_RowEditing(object sender, GridViewEditEventArgs e)
        {
            var key = int.Parse(grvUser.DataKeys[e.NewEditIndex].Value.ToString());
            Response.Redirect("edit-category-news.aspx?id=" + key);
        }

        protected void Change_Selected_CateType(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
