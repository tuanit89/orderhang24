using System;
using Models.Entity;
using tuanva.Core;

namespace Website.admin
{
    public partial class edit_support : System.Web.UI.Page
    {
        protected bool IsEdit;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                IsEdit = true;
                if(!IsPostBack) BindSupport();
            }
        }

        protected bool AddNewSupport()
        {
            var info = new SupportInfo();
            info.Name = txtSupportName.Text;
            info.Phone = txtSDT.Text;
            info.Skype = txtSkype.Text;
            info.Phone = txtSDT.Text;
            info.Yahoo = txtYahoo.Text;
            return Models.DataAccess.SupportImpl.Instance.Add(info) > 0;
        }

        protected void BindSupport()
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]) || ConvertUtility.ToInt16(Request.QueryString["id"])==0)
            {
                Response.Redirect("edit-support.aspx", true);
            }
            var info = Models.DataAccess.SupportImpl.Instance.GetInfo(int.Parse(Request.QueryString["id"]));
            if (info == null || info.Id == 0)
            {
                Response.Redirect("edit-support.aspx", true);
                return;
            }
            txtSupportName.Text = info.Name;
            txtSDT.Text=info.Phone;
            txtSkype.Text = info.Skype;
            txtSDT.Text = info.Phone;
            txtYahoo.Text = info.Yahoo;
        }

        bool UpDateSupport()
        {
            var info = Models.DataAccess.SupportImpl.Instance.GetInfo(int.Parse(Request.QueryString["id"]));
            if (info == null || info.Id == 0)
            {
                Response.Redirect("edit-support.aspx", true);
                return false;
            }
            info.Name = txtSupportName.Text;
            info.Phone = txtSDT.Text;
            info.Skype = txtSkype.Text;
            info.Phone = txtSDT.Text;
            info.Yahoo = txtYahoo.Text;
            return Models.DataAccess.SupportImpl.Instance.Update(info) > 0;
        }

        protected void InsertAndNew_Click(object sender, EventArgs e)
        {
            var error = string.Empty;
            if(IsEdit)
            {
                if(UpDateSupport())
                {
                    Response.Redirect("edit-support.aspx", true);
                }
            }
            else
            {
                if(AddNewSupport())
                {
                    Response.Redirect("edit-support.aspx",true);
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
                    Response.Redirect("list-support.aspx", true);
                }
            }
            else
            {
                if (AddNewSupport())
                {
                    Response.Redirect("list-support.aspx", true);
                }
            }
        }
        
    }
}
