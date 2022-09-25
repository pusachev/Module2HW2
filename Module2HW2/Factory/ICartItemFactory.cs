using System;
using Module2HW2.Entity;

namespace Module2HW2.Factory
{
    public interface ICartItemFactory
    {
        ICartItem Create(IProduct product, uint qty = 1);
    }
}

