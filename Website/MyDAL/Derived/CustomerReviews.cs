using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SubSonic.Query;

namespace MyDAL
{
    public partial class CustomerReview
    {
        public static CustomerReview GetRandomReview()
        {
            var obj =   new Select("CustomerName", "CustomerComment")
                        .Top("1")
                        .From("CustomerReview")
                        .OrderAsc("NewID()")
                        .ExecuteSingle<CustomerReview>();
            return obj;
        }
    }
}