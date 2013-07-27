using System;
using Models;
using Models.Entity;

namespace Website.admin
{
    public partial class edit_category_news : System.Web.UI.Page
    {
        protected bool IsEdit;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtSort.Text = "0";
                BindCateType();
            }

            if(!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                if(!IsPostBack) BindCate();
                IsEdit = true;
            }
        }

        private void BindCateType()
        {
            var dt = Models.DataAccess.CateTypeImpl.GetList();
            drpCateType.DataSource = dt;
            drpCateType.DataTextField = "CateTypeName";
            drpCateType.DataValueField = "CateType";
            drpCateType.DataBind();
        }

        private void BindCate()
        {
            var id = int.Parse(Request.QueryString["id"]);
            var info = Models.DataAccess.NewsCategoryImpl.Instance.GetInfo(id);
            if(info==null){ Response.Redirect("list-category-news.aspx");return;}
            txtCategoryname.Text = info.Name;
            txtMota.Text = info.Description;
            txtTukhoa.Text = info.MetaDescription;
            drpCateType.SelectedValue = info.CateType;
            txtSort.Text = info.Sort.ToString();
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if(!IsEdit)
            {
                if(!AddNewCate()) return;
            }
            else
            {
                if(!UpdatCate()) return;
            }
            Response.Redirect("list-category-news.aspx");
        }

        private bool AddNewCate()
        {
            if(string.IsNullOrEmpty(txtCategoryname.Text) || string.IsNullOrEmpty(txtSort.Text))
            {
                ltrThongbao.Text = "Cần nhập đủ các trường!";
                return false;
            }
            var info = new NewsCategoryInfo();
            info.Name = txtCategoryname.Text;
            info.Description = txtMota.Text;
            info.MetaDescription = txtTukhoa.Text;
            info.CateType = drpCateType.SelectedValue;
            info.Sort = int.Parse(txtSort.Text);
            var nextid = UntilityFunction.nextId("NewsCategory");
            info.Link = Rewrite.GenCategory(txtCategoryname.Text, nextid);
            Models.DataAccess.NewsCategoryImpl.Instance.Add(info);
            return true;
        }

        protected void Unnamed1_Click2(object sender, EventArgs e)
        {
            if (!IsEdit)
            {
                if(!AddNewCate()) return;
            }
            else
            {
                if(string.IsNullOrEmpty(Request.QueryString["id"])) return;
                if(!UpdatCate()) return;
            }
            Response.Redirect("edit-category-news.aspx");
        }

        private bool UpdatCate()
        {
            if (string.IsNullOrEmpty(txtCategoryname.Text) || string.IsNullOrEmpty(txtSort.Text)) return false;
            var info = Models.DataAccess.NewsCategoryImpl.Instance.GetInfo(int.Parse(Request.QueryString["id"]));
            if(info!=null)
            {
                info.Name = txtCategoryname.Text;
                info.Description = txtMota.Text;
                info.MetaDescription = txtTukhoa.Text;
                info.Sort = int.Parse(txtSort.Text);
                info.CateType = drpCateType.SelectedValue;
                info.Link = Rewrite.GenCategory(info.Name, info.Id);
                Models.DataAccess.NewsCategoryImpl.Instance.Update(info);
                return true;
            }
            return false;
        }
    }
}
