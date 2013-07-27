using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Models;
using Models.Entity;
using tuanva.Core;

namespace Website.admin
{
    public partial class edit_product : System.Web.UI.Page
    {
        protected bool IsEdit
        {
            get { return ConvertUtility.ToBoolean(ViewState["IsEdit"]); }
            set { ViewState["IsEdit"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                btnXoaAnh.Visible = false;
                txtPrice.Text = "0";
                BindListCate();
                if(!string.IsNullOrEmpty(Request.QueryString["id"]) && ConvertUtility.ToInt32(Request.QueryString["id"])>0)
                    BindInfo();
            }
            DynamicBindProperties();
        }

        private void BindInfo()
        {
            var info = Models.DataAccess.ProductImpl.Instance.GetInfo(int.Parse(Request.QueryString["id"]));
            if (info == null || info.Id < 1)
            {
                Response.Redirect("edit-product.aspx");
                return;
            }
            IsEdit = true;
            lstCate.SelectedValue = info.CateId.ToString();
            txtProductName.Text = info.ProductName;
            txtDescription.Text = info.Description;
            txtTags.Text = info.Tag;
            txtContent.Text = info.Contents;
            txtAlt.Text = info.AltImage;
            txtPrice.Text = info.Price.ToString();
            chkSetHot.Checked = info.IsHot;
            chkSetMost.Checked = info.IsShowHome;
            if (!string.IsNullOrEmpty(info.Image))
            {
                btnXoaAnh.Visible = true;
                img.Text = "<img src=\"/Images/san-pham/" + info.Id / 1000 + "/" + info.Id + "/" + info.Image + "\" style=\"width:200px;\" />";
            }
            else
            {
                img.Text = "<img src=\"/Images/no_pic.png\" style=\"width:200px;\" />";
            }
        }

        private string UploadImage(int id)
        {
            string returns = "";
            var ext = Path.GetExtension(fUpload.FileName).ToLower();
            if (ext.Equals(".jpg") || ext.Equals(".png") || ext.Equals(".jpeg"))
            {
                var filename = UnicodeUtility.UrlRewriting(txtProductName.Text);
                var path = Server.MapPath("~/images/san-pham/" + id / 1000 + "/" + id + "/");
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                fUpload.SaveAs(path + filename + ext);
                returns = filename + ext;
            }
            return returns;
        }

        int Action()
        {
            ProductInfo info;
            if (IsEdit)
            {
                info = Models.DataAccess.ProductImpl.Instance.GetInfo(ConvertUtility.ToInt32(Request.QueryString["id"]));
                if (info == null || info.Id < 1)
                {
                    Response.Redirect("edit-product.aspx", true);
                    return 0;
                }
            }
            else
            {
                info = new ProductInfo();
                info.Id = UntilityFunction.nextId("Product");
            }
            info.ProductName = txtProductName.Text;
            info.CateId = ConvertUtility.ToInt16(lstCate.SelectedValue);
            info.Description = txtDescription.Text;
            info.Contents = txtContent.Text;
            info.AltImage = txtAlt.Text;
            info.Tag = txtTags.Text;
            info.Link = Rewrite.GenDetailProduct(lstCate.SelectedItem.Text, info.CateId, info.Id, info.ProductName);
            info.Price = ConvertUtility.ToInt32(txtPrice.Text);
            info.IsHot = chkSetHot.Checked;
            info.IsShowHome = chkSetMost.Checked;
            if (fUpload.HasFile)
            {
                info.Image = UploadImage(info.Id);
            }
            if (IsEdit)
                return Models.DataAccess.ProductImpl.Instance.Update(info);
            return Models.DataAccess.ProductImpl.Instance.Add(info);
        }

        private void BindListCate()
        {
            var list = Models.DataAccess.ProductCategoryImpl.Instance.GetAll();
            if(list==null || list.Count==0) return;
            var lstAfter = BindSequenceList2(1, 0, list);
            lstCate.DataSource = lstAfter;
            lstCate.DataBind();
        }

        protected void btnLuuVaThemmoi_Click(object sender, EventArgs e)
        {
            var i = Action();
            if(i==0) return;

            var list = new List<int>();
            foreach (TableRow tr in tblProperty.Rows)
            {
                var t = tr.Cells[1].Controls[0] as RadioButtonList;
                if (t != null)
                {
                    var val = int.Parse(t.SelectedValue);
                    list.Add(val);
                }
            }
            Models.DataAccess.PropertyProductImpl.Instance.AddListProperties(list,i);
            Response.Redirect("edit-product.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            var ret = Action();
            if(ret==0) return;
            string query=string.Empty;
            if (!string.IsNullOrEmpty(Request.QueryString["c"]))
                query = "?cate=" + Request.QueryString["c"];
            if (!string.IsNullOrEmpty(Request.QueryString["page"]))
                query += "&page=" + Request.QueryString["page"];
            Response.Redirect("list-product.aspx"+query);
        }

        protected void btnXoaAnh_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["id"]);
            var info = Models.DataAccess.ProductImpl.Instance.GetInfo(id);
            var path = Server.MapPath("~/Image/san-pham/" + info.Id / 1000 + "/" + info.Id + "/");
            if (Directory.Exists(path)) Directory.Delete(path);
            info.Image = "";
            Models.DataAccess.ProductImpl.Instance.Update(info);
            img.Text = "";
            btnXoaAnh.Visible = false;
        }

        private void DynamicBindProperties()
        {
            var lst = Models.DataAccess.FeatureImpl.Instance.GetList(ConvertUtility.ToInt32(lstCate.SelectedValue));
            if (lst == null || lst.Count == 0) return; 
            List<int> lstPr = null;
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                lstPr = Models.DataAccess.PropertyProductImpl.Instance.GetList(int.Parse(Request.QueryString["id"]));
            foreach (var info in lst)
            {
                var lstVal = Models.DataAccess.FeatureProductImpl.Instance.GetList(info.Id);
                if(lstVal.Count>0)
                {
                    var tr = new TableRow
                    {
                        CssClass = "tblSkinRow",
                    };

                    var td = new TableCell
                    {
                        CssClass = "tblSkinHeaderColumn",
                        Text = info.FeatureName,
                        Width = 300
                    };
                    tr.Cells.Add(td);

                    var td2 = new TableCell
                    {
                        CssClass = "tblSkinHeaderColumn",
                        Text = info.CateProductId.ToString(),
                    };
                    var cBoxList = new RadioButtonList();
                    cBoxList.RepeatColumns = 1;
                    cBoxList.RepeatLayout = RepeatLayout.Table;
                    cBoxList.ID = "cb_" + info.Id;

                    foreach (var info2 in lstVal)
                    {
                        var item = new ListItem(info2.Value, info2.Id.ToString());
                        if(lstPr!=null && lstPr.Count>0 && lstPr.Contains(info2.Id))
                        {
                            item.Selected = true;
                        }
                        cBoxList.Items.Add(item);
                    }
                    if(lstPr==null || lstPr.Count==0)
                    {
                        cBoxList.SelectedIndex=0;
                    }
                    td2.Controls.Add(cBoxList);
                    tr.Cells.Add(td2);

                    tblProperty.Rows.Add(tr);
                }
            }
        }

        public IList<ProductCategoryInfo> BindSequenceList2(int count, int parentId, IList<ProductCategoryInfo> cate)
        {
            var listNew = new List<ProductCategoryInfo>();
            var list = cate.Where(a => a.ParentId == parentId);
            if (list.Any())
            {
                foreach (var info in list)
                {
                    if (parentId != 0) info.Name = " " + Sub(count) + " " + info.Name;
                    listNew.Add(info);
                    var lst = BindSequenceList2(count + 3, info.Id, cate);
                    if (lst != null) listNew.AddRange(lst);
                }
                return listNew;
            }
            return null;
        }

        public string Sub(int count)
        {
            var sb = new StringBuilder();
            for (int i = count; i != 0; i--)
            {
                sb.Append("--");
            }
            return sb.ToString();
        }
    }
}
