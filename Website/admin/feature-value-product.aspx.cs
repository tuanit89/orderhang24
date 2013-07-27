using System;
using System.Web.UI.WebControls;
using tuanva.Core;

namespace Website.admin
{
    public partial class feature_value_product : System.Web.UI.Page
    {
        protected bool IsEdit
        {
            get { return Convert.ToBoolean(ViewState["IsEdit"]); }
            set { ViewState["IsEdit"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindCateProduct();
                BindListPropertyProduct();
                if(!string.IsNullOrEmpty(Request.QueryString["Id"]) && ConvertUtility.ToInt16(Request.QueryString["id"])>0)
                {
                    var info = Models.DataAccess.FeatureProductImpl.Instance.GetInfo(ConvertUtility.ToInt16(Request.QueryString["id"]));
                    if (info == null || info.Id > 0 == false)
                    {
                        Response.Redirect("feature-product.aspx");
                        return;
                    }
                    IsEdit = true;
                    txtFuncName.Text = info.Value;
                    drpNhomSP.SelectedValue = info.ProductCateId.ToString(); 
                    if(drpThuocTinh.SelectedIndex==-1)
                    {
                        BindListPropertyProduct();
                    }
                    drpThuocTinh.SelectedValue = info.FeatureId.ToString();
                    BindGrid();
                }
            }
        }

        private void BindListPropertyProduct()
        {
            var lst = Models.DataAccess.FeatureImpl.Instance.GetList(ConvertUtility.ToInt32(drpNhomSP.SelectedValue));
            drpThuocTinh.DataTextField = "FeatureName";
            drpThuocTinh.DataValueField = "Id";
            drpThuocTinh.DataSource = lst;
            drpThuocTinh.DataBind();
        }

        private void BindCateProduct()
        {
            drpNhomSP.Visible = true;
            var lstCate = Models.DataAccess.ProductCategoryImpl.Instance.GetAll();
            drpNhomSP.DataSource = lstCate;
            drpNhomSP.DataTextField = "Name";
            drpNhomSP.DataValueField = "Id";
            drpNhomSP.DataBind();
        }


        protected bool ActionCateProduct()
        {
            if (drpThuocTinh.SelectedIndex == -1) return true;
            if(IsEdit)
            {
                return Models.DataAccess.FeatureProductImpl.Instance.Update(ConvertUtility.ToInt32(Request.QueryString["id"]), txtFuncName.Text,
                                                              ConvertUtility.ToInt16(drpThuocTinh.SelectedValue)) > 0;
            }
            return Models.DataAccess.FeatureProductImpl.Instance.Add(txtFuncName.Text,ConvertUtility.ToInt16(drpThuocTinh.SelectedValue))>0;
        }

        protected void BT_Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("feature-value-product.aspx");
        }

        

        protected void InsertAndBack_Click(object sender, EventArgs e)
        {
            ActionCateProduct();
            txtFuncName.Text = string.Empty;
            BindGrid();
            Form.Action = "feature-value-product.aspx";
            IsEdit = false;
        }
        
        protected void drpLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            var lst = Models.DataAccess.FeatureProductImpl.Instance.GetList(ConvertUtility.ToInt32(drpThuocTinh.SelectedValue));
            grvPromote.DataSource = lst;
            grvPromote.DataBind();
        }

        protected void grvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(grvPromote.DataKeys[e.RowIndex].Value.ToString());
            Models.DataAccess.FeatureProductImpl.Instance.Delete(id);
            BindGrid();
            Form.Action = "feature-value-product.aspx";
            IsEdit = false;
        }

        protected void grvUser_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(grvPromote.DataKeys[e.NewEditIndex].Value.ToString());
            Response.Redirect("feature-value-product.aspx?id=" + id);
        }

        protected void grvUser_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            grvPromote.PageIndex = e.NewSelectedIndex;
            BindGrid();
        }

        protected void btnChangers(object sender, EventArgs e)
        {
            if(drpThuocTinh.SelectedIndex==-1) return;
            drpLoai_SelectedIndexChanged(sender, e);
        }

        protected void drpNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindListPropertyProduct();
        }
    }
}
