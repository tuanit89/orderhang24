using System;
using System.Collections.Generic;
using System.Linq;
using MyDAL;
using SubSonic.Query;
using SubSonic.Repository;
using SubSonic.Schema;

public partial class ChildPage : System.Web.UI.Page
{
    protected List<ProductCategory> Categories = ProductCategory.All().ToList();
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
}