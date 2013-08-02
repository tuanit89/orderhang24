using System;
using Models;
using Models.Entity;
using MyDAL;

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

            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                if (!IsPostBack) BindCate();
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
            var info = NewsCategory.SingleOrDefault(c => c.Id == id);
            if (info == null)
            {
                Response.Redirect("list-category-news.aspx");
                return;
            }
            txtCategoryname.Text = info.Name;
            txtMota.Text = info.Description;
            txtTukhoa.Text = info.MetaDescription;
            drpCateType.SelectedValue = info.CateType;
            txtSort.Text = info.Sort.ToString();
            txtheadline.Text = info.Headline;
            txtbelowheadline.Text = info.BelowHead;
            txtnote.Text = info.Note;
            txtbelow.Text = info.NoteBelow;
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (!AddOrUpdateCate()) return;
            Response.Redirect("list-category-news.aspx");
        }

        private bool AddOrUpdateCate()
        {
            if (string.IsNullOrEmpty(txtCategoryname.Text) || string.IsNullOrEmpty(txtSort.Text))
            {
                ltrThongbao.Text = "Cần nhập đủ các trường!";
                return false;
            }
            var id = 0;
            NewsCategory info=null;
            if(!string.IsNullOrEmpty(Request.QueryString["id"]) && int.TryParse(Request.QueryString["id"],out id))
            {
                info = NewsCategory.SingleOrDefault(a => a.Id == id);
            }
            if(info==null) info=new NewsCategory();

            info.Name = txtCategoryname.Text;
            info.Description = txtMota.Text;
            info.MetaDescription = txtTukhoa.Text;
            info.CateType = drpCateType.SelectedValue;
            info.Sort = int.Parse(txtSort.Text);
            
            if(info.Id==0)
            {
                var nextid = UntilityFunction.nextId("NewsCategory");
                info.Link = Rewrite.GenCategory(txtCategoryname.Text, nextid);
            }
            else
            {
                info.Link = Rewrite.GenCategory(txtCategoryname.Text, info.Id);
            }
            info.Headline = txtheadline.Text;
            info.BelowHead = txtbelowheadline.Text;
            info.Note = txtnote.Text;
            info.NoteBelow = txtbelow.Text;
            info.Save();
            return true;
        }

        protected void Unnamed1_Click2(object sender, EventArgs e)
        {
            if (!AddOrUpdateCate()) return;
            Response.Redirect("edit-category-news.aspx");
        }
    }
}
