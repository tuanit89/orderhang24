using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Models;
using Models.Entity;
using tuanva.Core;

namespace Website.admin
{
    public partial class list_product : System.Web.UI.Page
    {
        protected int n = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load_DDL();
                LoadGrid();
            }
            
        }

        private void Load_DDL()
        {
            var lstCateProduct = Models.DataAccess.ProductCategoryImpl.Instance.GetAll();
            if (lstCateProduct != null && lstCateProduct.Count > 0)
            {
                var lstAfter = BindSequenceList2(2, 0, lstCateProduct);
                DDL_ProductType.DataSource = lstAfter;
                DDL_ProductType.DataTextField = "Name";
                DDL_ProductType.DataValueField = "Id";
                DDL_ProductType.DataBind();
            }
            DDL_ProductType.Items.Insert(0, new ListItem("[Tất cả]", "0"));
        }

        private void LoadGrid()
        {
            var pageindex = 1;
            drpPageNum.Items.Clear();
            drpPageNum.Items.Add(new ListItem("1"));
            var cate = int.Parse(DDL_ProductType.SelectedItem.Value);
            if (!string.IsNullOrEmpty(Request.QueryString["page"]) && int.Parse(Request.QueryString["page"]) > 0)
            {
                pageindex = int.Parse(Request.QueryString["page"]);
            }
            if (!string.IsNullOrEmpty(Request.QueryString["cate"]) && int.Parse(Request.QueryString["cate"]) > 0)
            {
                cate = int.Parse(Request.QueryString["cate"]);
                DDL_ProductType.SelectedValue = cate.ToString();
            }
            int totalRow;
            var dtsNews = Models.DataAccess.ProductImpl.Instance.GetList(pageindex - 1, Config.RecordPerPage,
                                                                         out totalRow,cate);
            var totalPage = totalRow%Config.RecordPerPage == 0
                                ? totalRow/Config.RecordPerPage
                                : (totalRow/Config.RecordPerPage) + 1;
            if (totalPage > 1)
            {
                for (int i = 2; i <= totalPage; i++)
                {
                    drpPageNum.Items.Add(i.ToString());
                }
            }
            drpPageNum.DataBind();
            drpPageNum.SelectedValue = pageindex.ToString();
            GV_Product.DataSource = dtsNews;
            GV_Product.DataBind();
            n = totalRow;
        }

        protected void DDL_ProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("list-product.aspx?cate={0}", DDL_ProductType.SelectedValue));
        }

        protected void drpPageNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("list-product.aspx?cate={0}&page={1}",DDL_ProductType.SelectedValue,drpPageNum.SelectedValue));
            //LoadGrid();

        }

        protected void GV_Product_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GV_Product.PageIndex = e.NewPageIndex;
            LoadGrid();
        }

        protected void GV_Product_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GV_Product.DataKeys[e.RowIndex].Value);
            var t = Models.DataAccess.PropertyProductImpl.Instance.Delete(id);
            Models.DataAccess.ProductImpl.Instance.Delete(id);
            LoadGrid();
        }

        protected void GV_Product_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string page = "";
            if (!string.IsNullOrEmpty(Request.QueryString["page"]) &&
                ConvertUtility.ToInt16(Request.QueryString["page"]) > 0)
            {
                page = "page=" + Request.QueryString["page"];
            }
            Response.Redirect("edit-product.aspx?id=" + GV_Product.DataKeys[e.NewEditIndex].Value + "&c=" +
                              DDL_ProductType.SelectedValue + "&" + page);
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
