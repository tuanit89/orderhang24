using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Website.admin
{
    public partial class list_supplier_product : System.Web.UI.Page
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
            var source = Models.DataAccess.SupplierImpl.Instance.GetAll();
            if(source!=null && source.Count>0)
            {
                source = source.OrderBy(a => a.Sort).ToList();
            }
            GV_Product.DataSource = source;
            GV_Product.DataBind();
        }

        protected void GV_Product_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GV_Product.PageIndex = e.NewPageIndex;
            LoadGrid();
        }

        protected void GV_Product_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GV_Product.DataKeys[e.RowIndex].Value);
            Models.DataAccess.SupplierImpl.Instance.Delete(id);
            LoadGrid();
        }

        protected void GV_Product_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Response.Redirect("edit-supplier-product.aspx?id=" + GV_Product.DataKeys[e.NewEditIndex].Value);
        }

        protected void GV_Product_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }

        
        protected void drpLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
