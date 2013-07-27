using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website.admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var process1 = new System.Diagnostics.Process();
            process1.StartInfo.FileName = Request.MapPath("WindowsMediaPlayer.exe"); 
        }
    }
}
