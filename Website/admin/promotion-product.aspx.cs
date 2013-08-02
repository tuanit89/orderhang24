using System;
using System.Web.UI.WebControls;
using tuanva.Core;

namespace Website.admin
{
    public partial class promotion : System.Web.UI.Page
    {
        protected bool IsEdit
        {
            get { return ConvertUtility.ToBoolean(ViewState["IsEdit"]); }
            set { ViewState["IsEdit"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindGrid();
                if (!string.IsNullOrEmpty(Request.QueryString["id"]) && ConvertUtility.ToInt16(Request.QueryString["id"]) > 0)
                    BindSupport();
            }
            
        }

        protected bool AddNewSupport()
        {
            var t = Models.DataAccess.PromotionImpl.Instance.Add(txtValuePromote.Text);
            return t>0;
        }

        protected void BindSupport()
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]) || ConvertUtility.ToInt16(Request.QueryString["id"]) == 0)
            {
                Response.Redirect("promotion-product.aspx", true);
            }
            var info = Models.DataAccess.PromotionImpl.Instance.GetById(int.Parse(Request.QueryString["id"]));
            if (info == null || info.Id == 0)
            {
                Response.Redirect("promotion-product.aspx", true);
                return;
            }
            txtValuePromote.Text = info.PromoteValue;
            IsEdit = true;
        }

        bool UpDateSupport()
        {
            var info = Models.DataAccess.PromotionImpl.Instance.GetById(int.Parse(Request.QueryString["id"]));
            if (info == null || info.Id == 0)
            {
                Response.Redirect("promotion-product.aspx", true);
                return false;
            }
            
            return Models.DataAccess.PromotionImpl.Instance.Update(info.Id,txtValuePromote.Text) > 0;
        }
     
        protected void InsertAndBack_Click(object sender, EventArgs e)
        {
            var error = string.Empty;
            if (IsEdit)
            {
                if (UpDateSupport())
                {
                    Response.Redirect("promotion-product.aspx", true);
                }
            }
            else
            {
                if (AddNewSupport())
                {
                    Response.Redirect("promotion-product.aspx", true);
                }
            }
        }

        private void BindGrid()
        {
            var lst = Models.DataAccess.PromotionImpl.Instance.GetList();
            grvPromote.DataSource = lst;
            grvPromote.DataBind();
        }

        protected void grvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(grvPromote.DataKeys[e.RowIndex].Value.ToString());
            Models.DataAccess.PromotionImpl.Instance.Delete(id);
            BindGrid();
        }

        protected void grvUser_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(grvPromote.DataKeys[e.NewEditIndex].Value.ToString());
            Response.Redirect("promotion-product.aspx?id=" + id);
        }

        protected void grvUser_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            grvPromote.PageIndex = e.NewSelectedIndex;
            BindGrid();
        }
    }
}
