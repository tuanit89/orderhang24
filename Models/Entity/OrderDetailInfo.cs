using System;

namespace Models.Entity
{
	[Serializable]
	public class OrderDetailInfo
	{
		public int id { get; set; }
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int price { get; set; }
		public int Number { get; set; }
        public string size{ get; set; }
        public int total { get { return price * Number; } }
        public OrderDetailInfo()
        {
            id = 0;
            OrderId = 0;
            ProductId = 0;
            ProductName = string.Empty;
            price = 0;
            Number = 0;
            size = string.Empty;
        }
	}
}
