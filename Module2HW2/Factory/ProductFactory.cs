using System;
using Module2HW2.Entity;

namespace Module2HW2.Factory
{
    public class ProductFactory : IProductFactory
    {
        public IProduct Create(string sku, string name, double price)
        {
            return new Product(sku, name, price);
        }
    }
}

