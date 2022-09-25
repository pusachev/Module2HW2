using System;
namespace Module2HW2.Entity
{
    public class CartItem : ICartItem
    {
        public string Sku { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public uint Qty { get; set; }
        public IProduct Product { get; private set; }
        public ICartItem? Next { get; set; }

        public CartItem(IProduct product, uint qty)
        {
            Sku = product.Sku;
            Name = product.Name;
            Price = product.Price;
            Qty = qty;
            Product = product;
        }
    }
}

