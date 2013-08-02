using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Models;
using Models.Entity;
using tuanva.Core;

namespace Website.admin
{
    public partial class edit_category_product : System.Web.UI.Page
    {
        protected bool IsEdit
        {
            get { return ConvertUtility.ToBoolean(ViewState["IsEdit"]); }
            set { ViewState["IsEdit"] = value; }
        }

        protected List<ProductCategoryInfo> Product;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var lstCate = Models.DataAccess.ProductCategoryImpl.Instance.GetListByParent(0);
                drpCate.DataSource = lstCate;
                drpCate.DataBind();
                drpCate.Items.Insert(0,new ListItem("[- Cấp cha- ]","0"));

                txtSort.Text = "1";
                if(!string.IsNullOrEmpty(Request.QueryString["Id"]) && ConvertUtility.ToInt16(Request.QueryString["id"])>0)
                    loadinfo();
            }
        }

        private void loadinfo()
        {
            var id = ConvertUtility.ToInt16(Request.QueryString["id"]);
            var info = Models.DataAccess.ProductCategoryImpl.Instance.GetInfo(id);
            if (info == null || info.Id<1 )
            {
                Response.Redirect("edit-category-product.aspx", true);
                return;
            }
            
            txtCategoryname.Text = info.Name;
            txtDesc.Text = info.Description;
            txtMota.Text = info.MetaDescription;
            //txtTukhoa.Text = info.MetaKeyword;
            txtSort.Text = info.Sort.ToString();

            foreach (ListItem item in drpCate.Items)
            {
                if (item.Value == info.Id.ToString())
                {
                    drpCate.Items.Remove(item);
                    break;
                }
            }

            drpCate.SelectedValue = info.ParentId.ToString();
            IsEdit = true;
        }

        protected bool ActionCateProduct()
        {
            ProductCategoryInfo info;
            if(IsEdit)
            {
                info = Models.DataAccess.ProductCategoryImpl.Instance.GetInfo(ConvertUtility.ToInt16(Request.QueryString["id"]));
                if (info == null || info.Id < 1) { 
                    Response.Redirect("edit-category-product.aspx", true);
                    return false;
                }
            }
            else
            {
                info=new ProductCategoryInfo();
                info.Id = UntilityFunction.nextId("ProductCategory");
            }
            info.Name = txtCategoryname.Text.Trim();
            info.Description = txtDesc.Text;
            info.MetaDescription = txtMota.Text;
            info.ParentId = int.Parse(drpCate.SelectedValue);
            info.Link = Rewrite.GenCategoryProduct(info.Name,info.Id);
            info.Sort = int.Parse(txtSort.Text);
            
            if(IsEdit)
            {
                return Models.DataAccess.ProductCategoryImpl.Instance.Update(info) > 0;
            }
            return Models.DataAccess.ProductCategoryImpl.Instance.Add(info) > 0;
        }

        protected void BT_Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("list-category-product.aspx");
        }

        
        protected void InsertAndBack_Click(object sender, EventArgs e)
        {
            if (ActionCateProduct())
            {
                Response.Redirect("list-category-product.aspx?type=0");
            }
        }

        protected void InsertAndNew_Click(object sender, EventArgs e)
        {
            if (ActionCateProduct())
            {
                Response.Redirect("edit-category-product.aspx");
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            var id = ConvertUtility.ToInt16(Request.QueryString["id"]);
            var info = Models.DataAccess.ProductCategoryImpl.Instance.GetInfo(id);
            info.Image = string.Empty;
            Models.DataAccess.ProductCategoryImpl.Instance.Update(info);
        }
    }
}
