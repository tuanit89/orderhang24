

using System;

namespace Models.Entity
{
    [Serializable]
    public class ProductInfo
    {
        public int Id { get; set; }
        public int CateId { get; set; }
        public string Model { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public string Image { get; set; }
        public string AltImage { get; set; }
        public string Contents { get; set; }
        public bool IsHot { get; set; }
        public bool IsShowHome { get; set; }
        public double Price { get; set; }
        public string Link { get; set; }
        public DateTime DateCreate { get; set; }
        public int SupplierId { get; set; }

        //Extend property
        public int Quantity { get; set; }
        public string SupplierName { get; set; }
        public double TotalPrice
        {
            get { return Quantity * Price; }
        }

    }
}
