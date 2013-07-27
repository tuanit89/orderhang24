using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
}
