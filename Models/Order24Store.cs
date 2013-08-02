using System.Collections.Generic;
using System.Linq;
using Models.Entity;

namespace Models
{
    public class Order24Store
    {
        private static Order24Store _order24;
        public static Order24Store Instance
        {
            get { return _order24 ?? (_order24 = new Order24Store()); }
        }

        public List<SupportInfo> Supports
        {
            get
            {
                var lst = DataAccess.SupportImpl.Instance.GetList();
                return lst;
            }
        }

        public List<NewsInfo> ExpNews
        {
            get
            {
                int outs;
                var lst = DataAccess.NewsImpl.Instance.GetList(0,2,out outs,"tin-tuc");
                return lst;
            }
        }

        public List<SliderInfo> Sliders
        {
            get
            {
                var lstSliders = DataAccess.SliderImpl.Instance.GetAll();
                return lstSliders;
            }
        } 


    }
}
