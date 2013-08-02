using System;
using System.IO;
using MyDAL;
using tuanva.Core;

namespace Website.admin
{
    public partial class edit_image_column : System.Web.UI.Page
    {
        protected bool IsEdit{
            get
            {
                return (ViewState["IsEdit"] != null && bool.Parse(ViewState["IsEdit"].ToString()));
            }
            set { ViewState["IsEdit"] = value; }
            }

        protected ImageColumn column { get; set; }

        private const string FolderRoot = "~/images/columns/";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                img.Visible = false;
                txtSort.Text = "0"; 
                if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
                {
                    IsEdit = true;
                    int id;
                    int.TryParse(Request.QueryString["Id"], out id);
                    column = ImageColumn.SingleOrDefault(c => c.Id == id);
                    if (column == null)
                    {
                        Response.Redirect("edit-image-column.aspx");
                        return;
                    }
                    txtColumnName.Text = column.ImageColumnName;
                    txtalt.Text = column.Alternate;
                    txtSort.Text = column.Sort.ToString();
                    txtname1.Text = column.Name1;
                    txtname2.Text = column.Name2;
                    txtname3.Text = column.Name3;
                    txtlink.Text = column.Link;
                    drpCateType.SelectedValue = column.LocationType;
                    if (!string.IsNullOrEmpty(column.Image))
                    {
                        img.Visible = true;
                        img.ImageUrl = FolderRoot + column.Image;
                    }
                    else
                    {
                        img.Visible = false;
                    }
                }
            }
        }
        
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
           if (!AddOrUpdateColumn()) return;
           Response.Redirect("list-image-column.aspx");
        }

        private bool AddOrUpdateColumn()
        {
            int id;
            if (!string.IsNullOrEmpty(Request.QueryString["id"]) && int.TryParse(Request.QueryString["id"],out id))
            {
                int.TryParse(Request.QueryString["Id"], out id);
                column = ImageColumn.SingleOrDefault(c => c.Id == id);
            }
            if(column==null) column=new ImageColumn();
            column.ImageColumnName = txtColumnName.Text.Trim();
            column.Sort = int.Parse(txtSort.Text.Trim());
            column.Name1 = txtname1.Text.Trim();
            column.Name2 = txtname2.Text.Trim();
            column.Name3 = txtname3.Text.Trim();
            column.LocationType = drpCateType.SelectedValue;
            column.Alternate = txtalt.Text.Trim();
            column.Link = txtlink.Text.Trim();

            if (drpCateType.SelectedValue=="top4" && txtimage.HasFile)
            {
                var path = Server.MapPath(FolderRoot);
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                var ext = Path.GetExtension(Path.Combine(path, txtimage.FileName));
                if(ext.ToLower().IndexOf("jpg")==-1 && ext.ToLower().IndexOf("png")==-1 && ext.ToLower().IndexOf("jpeg")==-1)
                {
                    ltrThongbao.Text = "File ảnh không hợp lệ";
                    return false;
                }
                txtimage.SaveAs(Path.Combine(path, UnicodeUtility.UrlRewriting(txtColumnName.Text) + ext));
                column.Image = UnicodeUtility.UrlRewriting(txtColumnName.Text) + ext;
            }

            column.Save();
            return true;
        }

        protected void Unnamed1_Click2(object sender, EventArgs e)
        {
            if(!AddOrUpdateColumn()) return;
            Response.Redirect("edit-image-column.aspx");
        }
    }
}
