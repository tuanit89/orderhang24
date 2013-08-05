using System;
using System.IO;
using Website.Controls;

public partial class SiteMaster : MasterBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        ltrOpenGraph.Text = FacebookSnippet;
        description.Content = MetaDescription;
    }

    protected string HtmlAddress
    {
        get { 
            var r = new StreamReader(Server.MapPath("~/html/Address.html"));
            var txt = r.ReadToEnd();
            r.Close();
            return txt;
        }
    }

    protected string HtmlLink
    {
        get { 
            var r = new StreamReader(Server.MapPath("~/html/Link.html"));
            var txt = r.ReadToEnd();
            r.Close();
            return txt;
        }
    }

    protected string HtmlFooter
    {
        get { 
            var r = new StreamReader(Server.MapPath("~/html/footer.htm"));
            var txt = r.ReadToEnd();
            r.Close();
            return txt;
        }
    }
}
