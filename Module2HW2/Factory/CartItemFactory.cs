using System;
using Module2HW2.Entity;

namespace Module2HW2.Factory
{
    public class CartItemFactory: ICartItemFactory 
    {
        public ICartItem Create(IProduct product, uint qty = 1)
        {
            return new CartItem(product, qty);
        }
    }
}
