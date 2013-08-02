using System;
using System.Collections.Generic;
using MyDAL;

public partial class _Default : System.Web.UI.Page
{
    protected List<Support> Supports = Support.ListSupports;
    protected List<News> Newses = News.ListNewsByType(2,"tin-tuc");
    protected List<News> Top4ServiceNews = News.ListNewsByType(4,"dich-vu");
    protected CustomerReview Review = CustomerReview.GetRandomReview();
}
