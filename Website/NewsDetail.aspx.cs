using System;
using System.Text;
using Models.Entity;
using Website.Controls;

public partial class NewsDetail : System.Web.UI.Page
{
    protected NewsInfo NewsInfo;
    protected string BreadCumps;
    protected void Page_Load(object sender, EventArgs e)
    {
        var id = Request.QueryString["d"];
        if (string.IsNullOrEmpty(id))
        {
            Response.Redirect("/");
            return;
        }
        NewsInfo = Models.DataAccess.NewsImpl.Instance.GetInfo(int.Parse(id));
        BreadCumps = Models.StringHelper.RichSnippet.SetBreadCumps("/", "Trang chủ", true);
        var cat = Models.DataAccess.NewsCategoryImpl.Instance.GetInfo(NewsInfo.CateId);
        Title = string.Format("{0} - {1}", NewsInfo.Title, cat.Name);
        var megaCat = Models.DataAccess.CateTypeImpl.GetInfo(cat.CateType);
        BreadCumps += Models.StringHelper.RichSnippet.SetBreadCumps("/" + cat.CateType + ".aspx", megaCat.CateTypeName, true);
        BreadCumps += Models.StringHelper.RichSnippet.SetBreadCumps(cat.Link, cat.Name, false);
        //Set Facebook
        var m = (MasterBase)Master;
        m.MetaDescription = NewsInfo.MetaDescription;
        m.FacebookOpenGraph(string.IsNullOrEmpty(NewsInfo.Image) ? "" : string.Format("/images/news/{0}/{1}/{2}", NewsInfo.Id / 1000, NewsInfo.Id, NewsInfo.Image));

        //Set Newsest news
        var lstNewsest = Models.DataAccess.NewsImpl.Instance.GetListNewsByWeek(NewsInfo.Id, NewsInfo.CateId);
        //rptNewsestNews.DataSource = lstNewsest;
        //rptNewsestNews.DataBind();
        //Set Relate News
        var lstRelate = Models.DataAccess.NewsImpl.Instance.GetListRelate(NewsInfo.Id, NewsInfo.CateId);
        //rptNewsRelate.DataSource = lstRelate;
        //rptNewsRelate.DataBind();

        Models.DataAccess.NewsImpl.Instance.AddPageView(NewsInfo.Id);
    }

    protected string ProcessingTags(string text)
    {
        var lstWord = text.Split(',');
        if (lstWord.Length > 0)
        {
            var sb = new StringBuilder();
            foreach (var s in lstWord)
            {
                sb.Append("<a href=\"/tags/" + s.Trim().ToLower().Replace(' ', '-') + ".aspx" + "\">" + s.Trim().ToLower() + "</a>");
            }
            return sb.ToString();
        }
        return "-";
    }

    protected void UpdateCounter()
    {

    }
}