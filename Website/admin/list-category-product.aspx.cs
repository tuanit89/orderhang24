using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Models.Entity;

namespace Website.admin
{
    public partial class list_category_product : System.Web.UI.Page
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
            var source = Models.DataAccess.ProductCategoryImpl.Instance.GetAll();
            if(source!=null && source.Count>0)
            {
                var sourceOrder = BindSequenceList2(1, 0, source);
                GV_Product.DataSource = sourceOrder;
                GV_Product.DataBind();
            }
            
        }

        protected void GV_Product_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GV_Product.PageIndex = e.NewPageIndex;
            LoadGrid();
        }

        protected void GV_Product_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GV_Product.DataKeys[e.RowIndex].Value);
            Models.DataAccess.ProductCategoryImpl.Instance.Delete(id);
            LoadGrid();
        }

        protected void GV_Product_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Response.Redirect("edit-category-product.aspx?id=" + GV_Product.DataKeys[e.NewEditIndex].Value);
        }

        protected void GV_Product_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }

        
        protected void drpLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        public IList<ProductCategoryInfo> BindSequenceList2(int count, int parentId, IList<ProductCategoryInfo> cate)
        {
            var listNew = new List<ProductCategoryInfo>();
            var list = cate.Where(a => a.ParentId == parentId);
            if (list.Any())
            {
                foreach (var info in list)
                {
                    if (parentId != 0) info.Name = " " + Sub(count) + " " + info.Name;
                    listNew.Add(info);
                    var lst = BindSequenceList2(count + 3, info.Id, cate);
                    if (lst != null) listNew.AddRange(lst);
                }
                return listNew;
            }
            return null;
        }

        public string Sub(int count)
        {
            var sb = new StringBuilder();
            for (int i = count; i != 0; i--)
            {
                sb.Append("--");
            }
            return sb.ToString();
        }
    }
}
