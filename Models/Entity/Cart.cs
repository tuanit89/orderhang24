using System;
using System.Collections.Generic;
using System.Linq;

namespace Models.Entity
{
    [Serializable]
    public class Cart
    {
        public CustomerInfo User { get; set; }
        public List<ProductInfo> LstProduct { get; private set; }
        public int Step { get; set; }
        public Cart()
        {
            LstProduct = new List<ProductInfo>();
            Step = 1;
        }
        public void AddProduct(ProductInfo product)
        {
            var info = LstProduct.Where(a => a.Id == product.Id);
            if (info.Any())
            {//Co
                foreach (ProductInfo t in LstProduct)
                {
                    if (t.Id == product.Id)
                    {
                        t.Quantity += 1;
                        break;
                    }
                }
            }
            else
            {
                product.Quantity = 1;
                LstProduct.Add(product);
            }
        }

        public void RemoveProduct(int pId)
        {
            if (LstProduct == null) LstProduct = new List<ProductInfo>();
            var info = LstProduct.FirstOrDefault(a => a.Id == pId);
            if (info != null) LstProduct.Remove(info);
        }

        public void UpdateQuantity(int pId, int quantity)
        {
            if (LstProduct.Any(a => a.Id == pId))
            {//Co
                foreach (ProductInfo t in LstProduct)
                {
                    if (t.Id == pId)
                    {
                        if (quantity < 1 || quantity > 1000) quantity = 1;
                        t.Quantity = quantity;
                        break;
                    }
                }
            }

        }

        public void RemoveAll()
        {
            LstProduct.Clear();
        }

        public double TotalPrice
        {
            get { return LstProduct.Sum(a => a.TotalPrice); }
        }

        public int TotalProduct
        {
            get{return LstProduct.Sum(a => a.Quantity);}
        }
    }
}
