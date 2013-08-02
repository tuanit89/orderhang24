using System;
using System.IO;
using tuanva.Core;

namespace Website.admin
{
    public partial class download_other : System.Web.UI.Page
    {
        private string _folder = "~/download/";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertAndNew_Click(object sender, EventArgs e)
        {
            var dir = Server.MapPath(_folder);
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            

            if (!fUpload.HasFile)
            {
                lblThongBao.Text = "Bạn chưa nhập file!";
                return;
            }

            var files = Directory.GetFiles(dir);
            foreach(var file in files){
                File.Delete(file);
            }

            var ext = Path.GetExtension(fUpload.FileName);
            if(ext.ToLower().IndexOf("xls")==-1 && ext.ToLower().IndexOf("xlsx")==-1)
            {
                lblThongBao.Text = "File không hợp lệ! Định dạng phải là xls hoặc xlsx";
                return;
            }

            fUpload.SaveAs(Path.Combine(dir, UnicodeUtility.UrlRewriting(Path.GetFileName(fUpload.FileName)) + ext));
            lblThongBao.Text = "Upload thành công!";
        }
    }
}