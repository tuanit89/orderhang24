using System;
using System.IO;
using System.Web;
using Models;
using Models.DataAccess;
using Models.Entity;
using tuanva.Core;

namespace Website.admin
{
    public partial class edit_slideshow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    HD_ID.Value = Request.QueryString["id"];
                    int id = UntilityFunction.IntegerForNull(HD_ID.Value);
                    loadinfo(id);
                }
            }
        }

        private void loadinfo(int id)
        {
            var info = SliderImpl.Instance.GetInfo(id);
            if (info != null)
            {
                LB_Messenger.Text = "Sửa thông tin slideshow";
                HD_ID.Value = info.id.ToString();
                TB_Name.Text = info.name;
                TB_Alt.Text = info.alt;
                TB_Link.Text = info.link;
                Image1.ImageUrl = info.image != ""
                                      ? Config.GetPathSlideshow + info.image
                                      : Config.GetPathNoImage;
                HD_Image.Value = info.image;
            }
            else
            {
                LB_Messenger.Text = "Thêm mới slideshow";
                HD_ID.Value = "0";
                TB_Name.Text = "";
                TB_Link.Text = "";
                TB_Alt.Text = "";
                Image1.ImageUrl = Config.GetPathNoImage;
                HD_Image.Value = "";
                TB_Alt.Text = "";
            }
        }

        protected void Link_Save_Click(object sender, EventArgs e)
        {
            save();
            Response.Redirect("edit-slideshow.aspx");
        }

        private void save()
        {
            string sImage = UploadImage();
            if (sImage != "") HD_Image.Value = sImage;

            int id = UntilityFunction.IntegerForNull(HD_ID.Value);
            SliderInfo info = new SliderInfo();
            info.id = id;
            info.name = TB_Name.Text;
            info.image = HD_Image.Value;
            info.alt = TB_Alt.Text;
            info.link = TB_Link.Text;
            if (id > 0)
            {
                SliderImpl.Instance.Update(info);
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                HD_ID.Value = SliderImpl.Instance.Add(info).ToString();
                MessageBox.Show("Thêm mới thành công");
                LB_Messenger.Text = "Sửa thông tin slideshow";
            }

            Image1.ImageUrl = info.image != ""
                                      ? Config.GetPathSlideshow + info.image
                                      : Config.GetPathNoImage;
        }

        protected void Link_SaveAndBack_Click(object sender, EventArgs e)
        {
            save();
            Response.Redirect("list-slideshow.aspx");
        }

        private string UploadImage()
        {
            string returns = "";
            var ext = Path.GetExtension(Upload_Images.FileName).ToLower();
            if (ext.Equals(".jpg") || ext.Equals(".png") || ext.Equals(".jpeg"))
            {
                var filename = UnicodeUtility.UrlRewriting(TB_Name.Text);
                var path = Server.MapPath("~/images/slider/");
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                Upload_Images.SaveAs(path + filename + ext);
                ResizeImage.ImageNoResize(Upload_Images.FileBytes, path + filename + ext,60);
                returns = filename + ext;
            }
            return returns;
        }
    }
}
