using System;
using Models.Entity;
using tuanva.Core;

namespace Website.admin
{
    public partial class edit_settings_other : System.Web.UI.Page
    {
        protected bool IsEdit
        {
            get { return ConvertUtility.ToBoolean(ViewState["IsEdit"]); }
            set { ViewState["IsEdit"] = value; }
        } 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !string.IsNullOrEmpty(Request.QueryString["Id"])) BindInfo();
        }

        private void BindInfo()
        {
            var info = Models.DataAccess.SettingImpl.Instance.GetByKey(Request.QueryString["id"]);
            if (string.IsNullOrEmpty(info.Key))
            {
                Response.Redirect("edit-settings-other.aspx", true);
                return;
            }
            txtKey.Text = info.Key;
            txtKey.ReadOnly = true;
            txtValue.Text = info.Value;
            txtDescripton.Text = info.Description;
            IsEdit = true;
        }

        private bool AddNew()
        {
            var info = new SettingInfo();
            info.Key = txtKey.Text.Trim();
            info.Value = txtValue.Text.Trim();
            info.Description = txtDescripton.Text;
            Models.DataAccess.SettingImpl.Instance.Add(info);
            return true;
        }

        private bool UpdateNew()
        {
            var info = Models.DataAccess.SettingImpl.Instance.GetByKey(Request.QueryString["id"]);
            info.Value = txtValue.Text.Trim();
            info.Description = txtDescripton.Text;
            
            Models.DataAccess.SettingImpl.Instance.Update(info);
            return true;
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                if (UpdateNew())
                {
                    Response.Redirect("list-settings-other.aspx");
                }
            }
            else
            {
                if (AddNew())
                {
                    Response.Redirect("list-settings-other.aspx");
                }
            }

        }

        protected void Unnamed1_Click2(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                if (UpdateNew())
                {
                    Response.Redirect("edit-download.aspx");
                }
            }
            else
            {
                if (AddNew())
                {
                    Response.Redirect("edit-download.aspx");
                }
            }

        }
    }
}
