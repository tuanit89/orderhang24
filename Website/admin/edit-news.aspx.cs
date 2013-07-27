using System;
using System.IO;
using Models;
using Models.Entity;
using tuanva.Core;

namespace Website.admin
{
    public partial class edit_news : System.Web.UI.Page
    {
        protected bool IsEdit;
        protected string Images = "/images/no_pic.png";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                chkAction.Checked = true;
                txtSort.Text = "0";
                BindDropCateNews();
                if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
                {
                    BindNews();
                }
                
            }
            if (!string.IsNullOrEmpty(Request.QueryString["Id"])) IsEdit = true;
        }

        private void BindDropCateNews()
        {
            var dropdatasorucre = Models.DataAccess.NewsCategoryImpl.Instance.GetAll("all");
            drpNhomTin.DataSource = dropdatasorucre;
            ViewState["drpNhomTin"] = dropdatasorucre;
            drpNhomTin.DataTextField = "name";
            drpNhomTin.DataValueField = "id";
            drpNhomTin.DataBind();
        }

        private void BindNews()
        {
            var info = Models.DataAccess.NewsImpl.Instance.GetInfo(int.Parse(Request.QueryString["Id"]));
            if(info!=null)
            {
                txtTenTin.Text = info.Title;
                txtMotaSeo.Text = info.MetaDescription;
                txtdesc.Text = info.Description;
                txtContent.Text = info.Content;
                chkAction.Checked = true;
                txtSort.Text = info.Sort.ToString();
                txtTags.Text = info.Tags;
                txtAlt.Text = info.AltImage;
                drpNhomTin.SelectedValue = info.CateId.ToString();
                if (!string.IsNullOrEmpty(info.Image))
                {
                    Images = string.Format("/images/news/{0}/{1}/{2}",info.Id / 1000 ,info.Id ,info.Image);
                }
            }
        }

        private bool AddNews()
        {
            if (string.IsNullOrEmpty(txtTenTin.Text) || string.IsNullOrEmpty(txtContent.Text))
            {
                ltrThongbao.Text = "Bắt buộc nhập tên tin và nội dung tin";
                return false;
            }
            var info = new NewsInfo();
            info.Title = txtTenTin.Text;
            info.CateId = int.Parse(drpNhomTin.SelectedValue);
            info.Content = txtContent.Text;
            info.MetaDescription = txtMotaSeo.Text;
            info.Description = txtdesc.Text;
            var nextId = UntilityFunction.nextId("News");
            info.AltImage = txtAlt.Text;
            info.Link = Rewrite.GenDetail(drpNhomTin.SelectedItem.Text, int.Parse(drpNhomTin.SelectedValue), nextId, info.Title);
            info.CreateDate = DateTime.Now;
            info.IsAttach = chkAction.Checked;
            info.Tags = txtTags.Text;
            info.Sort = int.Parse(txtSort.Text);
            if (upHinhanh.HasFile)
            {
                info.Image = UploadImage(nextId);
            }
            if(!string.IsNullOrEmpty(txtTags.Text))
            {
                foreach (var tag in txtTags.Text.Split(','))
                {
                    var txtTag = tag.Trim();
                    if(!string.IsNullOrEmpty(txtTag))
                    {
                        Models.DataAccess.TagsImpl.AddIfExist(txtTag.ToLower());
                    }
                }
            }
            Models.DataAccess.NewsImpl.Instance.Add(info);

            return true;
        }

        private string UploadImage(int id)
        {
            string returns="";
            var ext = Path.GetExtension(upHinhanh.FileName).ToLower();
            if(ext.Equals(".jpg") || ext.Equals(".png") || ext.Equals(".jpeg"))
            {
                var filename = UnicodeUtility.UrlRewriting(txtTenTin.Text);
                var path = Server.MapPath("~/images/news/" + id/1000 + "/" + id + "/");
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                upHinhanh.SaveAs(path+filename+ ext);
                //Re.ImageCrop(upHinhanh.FileBytes, path +"90.60."+ filename + ext, 90, 60, 60);
                //ResizeImage.ImageCrop(upHinhanh.FileBytes, path +"140.116."+ filename + ext, 140, 116, 60);
                returns = filename + ext;
            }
            return returns;
        }

        private bool EditNews()
        {
            var info = Models.DataAccess.NewsImpl.Instance.GetInfo(int.Parse(Request.QueryString["id"]));
            if(info!=null)
            {
                info.Title = txtTenTin.Text;
                info.CateId = int.Parse(drpNhomTin.SelectedValue);
                info.Content = txtContent.Text;
                info.MetaDescription = txtMotaSeo.Text;
                info.Description = txtdesc.Text;
                info.AltImage = txtAlt.Text;
                info.Link = Rewrite.GenDetail(drpNhomTin.SelectedItem.Text, info.Id, info.Id, info.Title);
                info.CreateDate = DateTime.Now;
                info.IsAttach = chkAction.Checked;
                info.Tags = txtTags.Text;
                info.Sort = int.Parse(txtSort.Text);
                if (upHinhanh.HasFile)
                {
                    info.Image = UploadImage(info.Id);
                }
                if (!string.IsNullOrEmpty(txtTags.Text))
                {
                    foreach (var tag in txtTags.Text.Split(','))
                    {
                        var txtTag = tag.Trim();
                        if (!string.IsNullOrEmpty(txtTag))
                        {
                            Models.DataAccess.TagsImpl.AddIfExist(txtTag.ToLower());
                        }
                    }
                }
                Models.DataAccess.NewsImpl.Instance.Update(info);
                return true;
            }
            return false;
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                //Update
                if(!EditNews()) return;
            }
            else
            {
                if(!AddNews()) return;
            }
            Response.Redirect("list-news.aspx");

        }

        protected void Unnamed1_Click2(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                //Update
                if (!EditNews()) return;
            }
            else
            {
                if (!AddNews()) return;
            }
            Response.Redirect("edit-news.aspx");
        }
    }
}
