using System;
using System.IO;

namespace dongphucdangcap.com.admin
{
    public partial class seo_other : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               LoadContent();
            }
        }

        protected void WriteStream(string filename)
        {
            var stream = new StreamWriter(Server.MapPath(filename));
            stream.Write(txtContent.Text);
            stream.Flush();
            stream.Close();
            stream.Dispose();
        }

        protected void btnAc_Click(object sender, EventArgs e)
        {
            var path = "~/html/websiteSetting.xml";
            WriteStream(path);
        }

        protected void LoadContent()
        {
            string path = "~/html/websiteSetting.xml";
            var streamReader = new StreamReader(Server.MapPath(path));
            var str = streamReader.ReadToEnd();
            streamReader.Close();
            streamReader.Dispose();
            txtContent.Text = str;
        }
    }
}
