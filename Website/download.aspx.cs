using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class download : System.Web.UI.Page
    {
        private const string FileDownload = "~/download/";
        protected void Page_Load(object sender, EventArgs e)
        {
            var dir = Server.MapPath(FileDownload);
            if(!Directory.Exists(dir))
                return;
            var file = string.Empty;
            var files = Directory.GetFiles(dir);
            if (files.Length > 0)
            {
                file = files[0];
            }
            else
            {
                Response.Write("This file does not exist.");
                return;
            }

            FileInfo fileInfo = new FileInfo(file);
            Response.Clear();
            Response.ClearHeaders();
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment; filename=" + fileInfo.Name);
            Response.AddHeader("Content-Type", "application/Excel");
            Response.ContentType = "application/vnd.xls";
            Response.AddHeader("Content-Length", fileInfo.Length.ToString());
            Response.WriteFile(fileInfo.FullName);
            Response.End();
        }

    }
}