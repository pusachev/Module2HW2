using System;
namespace Module2HW2.Entity
{
    public class Product: IProduct
    {
        public double Price { get; private set; }
        public string Name { get; private set; }
        public string Sku { get; private set; }

        public Product(string sku, string name, double price)
        {
            Sku = sku;
            Name = name;
            Price = price;
        }
    }
}

