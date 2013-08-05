using System;
using Models.Entity;
using Website.Controls;

public partial class Content : System.Web.UI.Page
{
    protected CateTypeInfo CateType;
    protected NewsInfo News;
    protected string Breadcumps;
    protected void Page_Load(object sender, EventArgs e)
    {
        var q = Request.QueryString["q"];
        if (string.IsNullOrEmpty(q))
        {
            Response.Redirect("/");
            return;
        }

        CateType = Models.DataAccess.CateTypeImpl.GetInfo(q.ToLower().Trim());
        if (CateType == null || string.IsNullOrEmpty(CateType.CateType))
        {
            Response.Redirect("/");
            return;
        }

        News = Models.DataAccess.NewsImpl.Instance.Get1Info(CateType.CateType);
        if (News == null || News.Id == 0)
        {
            News = new NewsInfo
            {
                Content = "Tin đang được cập nhật...",
                Title = CateType.CateTypeName,
                Description = "Tin đang được cập nhật..."
            };
        }
        Title = News.Title + " | OrderHang24.com";

        Breadcumps += Models.StringHelper.RichSnippet.SetBreadCumps("/", "Trang chủ", true);
        Breadcumps += Models.StringHelper.RichSnippet.SetBreadCumps("", CateType.CateTypeName, false);

        var ms = (MasterBase)Master;
        ms.MetaDescription = News.Description;
        
        ms.FacebookOpenGraph("");
    }
}