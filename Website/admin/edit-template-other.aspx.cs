using System;
using System.IO;

namespace Website.admin
{
    public partial class edit_template : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                
               
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
            switch (drpKhuvuc.SelectedValue)
            {
                case "1":
                    WriteStream("~/html/footer.htm");
                    break;

                case "2":
                    WriteStream("~/html/contact.htm");
                    break;
            }
        }

        protected void drpKhuvuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            const string folder = "~/html/";
            var check = int.Parse(drpKhuvuc.SelectedValue);
            switch (check)
            {
                case 1:
                    txtContent.Text = LoadContent(folder + "footer.htm");
                    break;
                case 2:
                    txtContent.Text = LoadContent(folder + "contact.htm");
                    break;
            }
            
        }

        protected string LoadContent(string path)
        {
            var streamReader = new StreamReader(Server.MapPath(path));
            var str = streamReader.ReadToEnd();
            streamReader.Close();
            streamReader.Dispose();
            return str;
        }
    }
}
