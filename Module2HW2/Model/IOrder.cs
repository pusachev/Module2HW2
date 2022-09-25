using System;
using Module2HW2.Entity;

namespace Module2HW2.Model
{
    public interface IOrder
    {
        double Total { get; }
        string OrderId { get; }
        ICartItem CartItem { get; }
        void Calculate();
    }
}

