using System;
using System.IO;
using System.Web.UI.WebControls;
using Models;

namespace Website.admin
{
    public partial class list_news : System.Web.UI.Page
    {
        private readonly int _pageSize = 20;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindDropCateNews();
                BindGridNews();
            }
        }

        private void BindGridNews()
        {
            var pageindex = 1;
            drpPageNum.Items.Clear();
            drpPageNum.Items.Add(new ListItem("1"));
            if(!string.IsNullOrEmpty(Request.QueryString["page"]) && int.Parse(Request.QueryString["page"])>1)
            {
                pageindex = int.Parse(Request.QueryString["page"]);
            }
            int totalRow;
            var dtsNews = Models.DataAccess.NewsImpl.Instance.GetList(pageindex - 1, _pageSize, out totalRow,int.Parse(drpCate.SelectedItem.Value));
            var totalPage = totalRow%_pageSize == 0 ? totalRow/_pageSize : (totalRow/_pageSize) + 1;
            if(totalPage>1)
            {
                for (int i = 2; i <= totalPage; i++)
                {
                    drpPageNum.Items.Add(i.ToString());
                }
            }
            drpPageNum.SelectedValue = pageindex.ToString();
            drpPageNum.DataBind();
            GridNews.DataSource = dtsNews;
            GridNews.DataBind();
        }

        private void BindDropCateNews()
        {
            var dtSource = Models.DataAccess.NewsCategoryImpl.Instance.GetAll("all");
            drpCate.DataSource = dtSource;
            drpCate.DataTextField = "name";
            drpCate.DataValueField = "id";
            drpCate.DataBind();
            drpCate.Items.Insert(0,new ListItem("[ Tất cả ]","0"));
        }

        protected void drpPageNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("list-news.aspx?page="+drpPageNum.SelectedItem.Value);
        }

        protected void DDL_ProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGridNews();
        }

        protected void GV_Product_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var newsid = int.Parse(GridNews.DataKeys[e.RowIndex].Value.ToString());
            Models.DataAccess.NewsImpl.Instance.Delete(newsid);
            string path = Server.MapPath("~/images/news/" + newsid / 1000 + "/" + newsid);
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
            BindGridNews();
        }

        protected void GV_Product_RowEditing(object sender, GridViewEditEventArgs e)
        {
            var newsid = int.Parse(GridNews.DataKeys[e.NewEditIndex].Value.ToString());
            Response.Redirect("edit-news.aspx?id="+newsid);
        }

        protected void btnSetHot_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridNews.Rows.Count; i++)
            {
                int id = UntilityFunction.IntegerForNull(GridNews.DataKeys[i].Value);
                var cb = (CheckBox)GridNews.Rows[i].FindControl("chkHot");
                //Models.DataAccess.NewsImpl.Instance.UpdateHot(id, cb.Checked);
            }
            BindGridNews();
        }
    }
}
