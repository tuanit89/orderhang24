using System.Collections.Generic;
using SubSonic.Query;

namespace MyDAL
{
    public partial class Support
    {
        public static List<Support> ListSupports
        {
            get
            {
                var quert = new Select("Yahoo", "Skype", "Phone", "Name")
                            .From("Support")
                            .ExecuteTypedList<Support>();
                return quert;
            }
        }
    }
}