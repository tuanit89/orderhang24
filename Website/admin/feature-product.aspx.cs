using System;
using System.Web.UI.WebControls;
using tuanva.Core;

namespace Website.admin
{
    public partial class feature_product : System.Web.UI.Page
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
                if(!string.IsNullOrEmpty(Request.QueryString["Id"]) && ConvertUtility.ToInt16(Request.QueryString["id"])>0)
                {
                    var info = Models.DataAccess.FeatureImpl.Instance.GetById(ConvertUtility.ToInt16(Request.QueryString["id"]));
                    if (info == null || info.Id > 0 == false)
                    {
                        Response.Redirect("feature-product.aspx");
                        return;
                    }
                    IsEdit = true;
                    txtFuncName.Text = info.FeatureName;
                    chkShare.Checked = info.IsShare;
                    drpNhomSP.SelectedValue = info.CateProductId.ToString();
                }
            }
        }

        private void BindCateProduct()
        {
            drpNhomSP.Visible = true;
            var lstCate = Models.DataAccess.ProductCategoryImpl.Instance.GetAll();
            drpNhomSP.DataSource = lstCate;
            drpNhomSP.DataTextField = "Name";
            drpNhomSP.DataValueField = "Id";
            drpNhomSP.DataBind();
            drpNhomSP.Items.Insert(0,new ListItem("[- Tất cả -]","0"));
        }


        protected bool ActionCateProduct()
        {
            if(IsEdit)
            {
                return Models.DataAccess.FeatureImpl.Instance.Update(ConvertUtility.ToInt32(Request.QueryString["id"]), txtFuncName.Text, ConvertUtility.ToInt16(drpNhomSP.SelectedValue), chkShare.Checked) > 0;
            }
            return Models.DataAccess.FeatureImpl.Instance.Add(txtFuncName.Text,ConvertUtility.ToInt16(drpNhomSP.SelectedValue),chkShare.Checked)>0;
        }

        protected void BT_Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("feature-product.aspx");
        }

        protected void InsertAndBack_Click(object sender, EventArgs e)
        {
            if (ActionCateProduct())
            {
                Form.Action = "feature-product.aspx";
                IsEdit = false;
                txtFuncName.Text = string.Empty;

                BindGrid();
            }
        }
        
        protected void drpLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            var lst = Models.DataAccess.FeatureImpl.Instance.GetList(ConvertUtility.ToInt32(drpNhomSP.SelectedValue));
            grvPromote.DataSource = lst;
            grvPromote.DataBind();
        }

        protected void grvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(grvPromote.DataKeys[e.RowIndex].Value.ToString());
            Models.DataAccess.FeatureImpl.Instance.Delete(id);
            //Models.DataAccess.f
            BindGrid();
        }

        protected void grvUser_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(grvPromote.DataKeys[e.NewEditIndex].Value.ToString());
            Response.Redirect("feature-product.aspx?id=" + id);
        }

        protected void grvUser_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            grvPromote.PageIndex = e.NewSelectedIndex;
            BindGrid();
        }

        protected void btnChangers(object sender, EventArgs e)
        {
            drpLoai_SelectedIndexChanged(sender, e);
        }
    }
}
