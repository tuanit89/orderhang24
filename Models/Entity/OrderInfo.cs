

using System;

namespace Models.Entity
{
	[Serializable]
	public class OrderInfo
	{
		public int OrderID { get; set; }
		public int CustomerID { get; set; }
		public string FullnameOrder { get; set; }
		public int SexOrder { get; set; }
		public string AddressOrder { get; set; }
		public string EmailOrder { get; set; }
		public string PhoneOrder { get; set; }
		public string MobileOrder { get; set; }
		public string FaxOrder { get; set; }
		public string OtherInfoOrder { get; set; }
		public string FullnameReceived { get; set; }
		public int SexReceived { get; set; }
		public string AddressReceived { get; set; }
		public string EmailReceived { get; set; }
		public string PhoneReceived { get; set; }
		public string MobileReceived { get; set; }
		public string FaxReceived { get; set; }
		public string OtherInfoReceived { get; set; }
		public int Shipping { get; set; }
		public string TransitTime { get; set; }
		public int Payment { get; set; }
		public int TotalPayment { get; set; }
		public int ProductNumber { get; set; }
		public int StatusOrder { get; set; }
		public DateTime OnOrder { get; set; }
        public OrderInfo()
        {
            OrderID = 0;
            CustomerID = 0;
            FullnameOrder = string.Empty;
            SexOrder = 0;
            AddressOrder = string.Empty;
            EmailOrder = string.Empty;
            PhoneOrder = string.Empty;
            MobileOrder = string.Empty;
            FaxOrder = string.Empty;
            OtherInfoOrder = string.Empty;
            FullnameReceived = string.Empty;
            SexReceived = 0;
            AddressReceived = string.Empty;
            EmailReceived = string.Empty;
            PhoneReceived = string.Empty;
            MobileReceived = string.Empty;
            FaxReceived = string.Empty;
            OtherInfoReceived = string.Empty;
            Shipping = 0;
            TransitTime = string.Empty;
            Payment = 0;
            TotalPayment = 0;
            ProductNumber = 0;
            StatusOrder = 0;
            OnOrder = DateTime.Now;
        }

	}
}
