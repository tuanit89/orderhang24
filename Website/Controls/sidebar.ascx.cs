using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.DataAccess;
using Models.Entity;
using Models.StringHelper;
using MyDAL;

namespace Website.Controls
{
    public partial class sidebar : System.Web.UI.UserControl
    {
        protected List<ProductCategory> Categories = ProductCategory.All().ToList();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}