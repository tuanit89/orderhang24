using System;
using System.Collections.Generic;
using System.Linq;
using MyDAL;

public partial class _Default : System.Web.UI.Page
{
    protected List<Support> Supports = Support.ListSupports;
    protected List<News> Newses = News.ListNewsByType(2,"kinh-nghiem").OrderBy(kn=>kn.Sort).ToList();
    protected List<News> Top4ServiceNews = News.ListNewsByType(4, "dich-vu").OrderBy(dv => dv.Sort).ToList();
    protected CustomerReview Review = CustomerReview.GetRandomReview();
    protected NewsCategory DichvuCategory = NewsCategory.SingleOrDefault(c => c.CateType == "dich-vu");
    protected List<ImageColumn> LisTop3;
    protected List<ImageColumn> ListTop4;

    protected void Page_Load(object sender, EventArgs evt)
    {
        var lstDichVu = ImageColumn.All();
        LisTop3 = lstDichVu.Where(dv => dv.LocationType == "top3").ToList();
        ListTop4 = lstDichVu.Where(dv => dv.LocationType == "top4").ToList();
    }

}
