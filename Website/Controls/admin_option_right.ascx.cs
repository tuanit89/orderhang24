using System;

namespace Website.Controls
{
    public partial class admin_option_right : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected int ProductCounter()
        {
            return 0;//ServiceFactory.GetInstanceProduct().Counter();
        }

        protected int NewsCounter()
        {
            return 10;// ServiceFactory.GetInstanceNews().Counter();
        }
    }
}