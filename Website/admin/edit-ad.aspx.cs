using System;
using System.IO;
using Models;
using Models.Entity;
using tuanva.Core;

namespace Website.admin
{
    public partial class edit_ad : System.Web.UI.Page
    {
        protected bool IsEdit;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) txtSort.Text = "1";
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                IsEdit = true;
            }
            if (!IsPostBack && !string.IsNullOrEmpty(Request.QueryString["id"]) && ConvertUtility.ToInt16(Request.QueryString["id"])>0) BindSupport();
        }

        protected bool AddNewSupport()
        {
            var info = new BoxAdInfo();
            info.Name = txtAdName.Text;
            info.Link = txtLink.Text;
            info.Description = txtDes.Text;
            info.Sort = int.Parse(txtSort.Text);
            info.Location = drpLocation.SelectedValue;
            if (fUpload.HasFile) info.Image = UploadImage();
            return Models.DataAccess.BoxAdImpl.Instance.Add(info) > 0;
        }

        protected void BindSupport()
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]) || ConvertUtility.ToInt16(Request.QueryString["id"]) == 0)
            {
                Response.Redirect("edit-ad.aspx", true);
            }
            var info = Models.DataAccess.BoxAdImpl.Instance.GetInfo(int.Parse(Request.QueryString["id"]));
            if (info == null || info.Id == 0)
            {
                Response.Redirect("edit-partner.aspx", true);
                return;
            }
            txtAdName.Text = info.Name;
            txtDes.Text = info.Description;
            txtLink.Text = info.Link;
            txtSort.Text = info.Sort.ToString();
            drpLocation.SelectedValue = info.Location;
            ltrHinhAnh.Text = "<img src=\"/Images/"+info.Location+"/" + info.Image + "\" style=\"width:200px;\" />";
        }

        bool UpDateSupport()
        {
            var info = Models.DataAccess.BoxAdImpl.Instance.GetInfo(int.Parse(Request.QueryString["id"]));
            if (info == null || info.Id == 0)
            {
                Response.Redirect("edit-parner.aspx", true);
                return false;
            }
            info.Name = txtAdName.Text;
            info.Description = txtDes.Text;
            info.Link = txtLink.Text;
            info.Sort = int.Parse(txtSort.Text);
            info.Location = drpLocation.SelectedValue;
            if (fUpload.HasFile)
            {
                info.Image = UploadImage();
            }
            return Models.DataAccess.BoxAdImpl.Instance.Update(info) > 0;
        }

        protected void InsertAndNew_Click(object sender, EventArgs e)
        {
            var error = string.Empty;
            if (IsEdit)
            {
                if (UpDateSupport())
                {
                    Response.Redirect("edit-ad.aspx", true);
                }
            }
            else
            {
                if (AddNewSupport())
                {
                    Response.Redirect("edit-ad.aspx", true);
                }
            }
        }

        protected void InsertAndBack_Click(object sender, EventArgs e)
        {
            var error = string.Empty;
            if (IsEdit)
            {
                if (UpDateSupport())
                {
                    Response.Redirect("list-ad.aspx", true);
                }
            }
            else
            {
                if (AddNewSupport())
                {
                    Response.Redirect("list-ad.aspx", true);
                }
            }
        }

        private string UploadImage()
        {
            string returns = "";
            var ext = Path.GetExtension(fUpload.FileName).ToLower();
            if (ext.Equals(".jpg") || ext.Equals(".png") || ext.Equals(".jpeg"))
            {
                var filename = UnicodeUtility.UrlRewriting(txtAdName.Text);
                var path = Server.MapPath("~/images/"+drpLocation.SelectedValue+"/");
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                fUpload.SaveAs(path + filename + ext);
                //ResizeImage.ImageCrop(fUpload.FileBytes, path + "156.0." + filename + ext, 156, 156, 60);
                returns = filename + ext;
            }
            return returns;
        }
    }
}
