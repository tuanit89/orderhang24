using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using Models;
using Models.Entity;
using tuanva.Core;

namespace Website.admin
{
    public partial class edit_supplier_product : System.Web.UI.Page
    {
        protected bool IsEdit
        {
            get { return ConvertUtility.ToBoolean(ViewState["IsEdit"]); }
            set { ViewState["IsEdit"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Danhmuc();
            if(!IsPostBack)
            {
                txtSort.Text = "1";
                if(!string.IsNullOrEmpty(Request.QueryString["Id"]) && ConvertUtility.ToInt16(Request.QueryString["id"])>0)
                {
                    loadinfo();
                }
            }
        }

        private void Load_Danhmuc()
        {
            var lst = Models.DataAccess.ProductCategoryImpl.Instance.GetAll();
            if(lst==null || lst.Count==0) return;
            var checkbox = new CheckBoxList()
                               {
                                   ID = "chkList",
                                   DataSource = lst,
                                   DataTextField = "Name",
                                   DataValueField = "Id",RepeatDirection = RepeatDirection.Horizontal,CellPadding = 5
                               };
            checkbox.DataBind();
            plcCheckboxList.Controls.Add(checkbox);
        }

        private void loadinfo()
        {
            var id = ConvertUtility.ToInt16(Request.QueryString["id"]);
            var info = Models.DataAccess.SupplierImpl.Instance.GetInfo(id);
            if (info == null || info.Id<1 )
            {
                Response.Redirect("edit-supplier-product.aspx", true);
                return;
            }
            
            txtCategoryname.Text = info.Name;
            txtDesc.Text = info.Description;
            txtMota.Text = info.MetaDescription;
            //txtTukhoa.Text = info.MetaKeyword;
            txtSort.Text = info.Sort.ToString();
            IsEdit = true;

            var plc = plcCheckboxList.Controls.OfType<CheckBoxList>().FirstOrDefault();
            if (!string.IsNullOrEmpty(info.HasCateId) && plc != null && plc.Items.Count > 0)
            {
                var lstString = info.HasCateId.Split(',');
                foreach (ListItem cklist in plc.Items)
                {
                    ListItem cklist1 = cklist;
                    if (lstString.Any(a => a == cklist1.Value))
                        cklist.Selected = true;
                }
                info.HasCateId = info.HasCateId.TrimEnd(',');
            }
        }

        protected bool ActionCateProduct()
        {
            SupplierInfo info;
            if(IsEdit)
            {
                info = Models.DataAccess.SupplierImpl.Instance.GetInfo(ConvertUtility.ToInt16(Request.QueryString["id"]));
                if (info == null || info.Id < 1) { 
                    Response.Redirect("edit-supplier-product.aspx", true);
                    return false;
                }
            }
            else
            {
                info=new SupplierInfo();
                info.Id = UntilityFunction.nextId("Supplier");
            }
            info.Name = txtCategoryname.Text.Trim();
            info.Description = txtDesc.Text;
            info.MetaDescription = txtMota.Text;
            info.ParentId = 0;
            info.Link = Rewrite.GenCategoryProduct(info.Name,info.Id);
            info.Sort = int.Parse(txtSort.Text);

            var plc = plcCheckboxList.Controls.OfType<CheckBoxList>().FirstOrDefault();
            if(plc!=null && plc.Items.Count>0)
            {
                info.HasCateId = string.Empty;
                foreach (ListItem cklist in plc.Items)
                {
                    if (cklist.Selected)
                        info.HasCateId += cklist.Value+",";
                }
                info.HasCateId = info.HasCateId.TrimEnd(',');
            }

            if(IsEdit)
            {
                return Models.DataAccess.SupplierImpl.Instance.Update(info) > 0;
            }
            return Models.DataAccess.SupplierImpl.Instance.Add(info) > 0;
        }

        protected void BT_Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("list-supplier-product.aspx");
        }

        
        protected void InsertAndBack_Click(object sender, EventArgs e)
        {
            if (ActionCateProduct())
            {
                Response.Redirect("list-supplier-product.aspx");
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
            var info = Models.DataAccess.SupplierImpl.Instance.GetInfo(id);
            info.Image = string.Empty;
            Models.DataAccess.SupplierImpl.Instance.Update(info);
        }
    }
}
