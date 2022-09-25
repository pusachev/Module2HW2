using System;
using Module2HW2.Entity;

namespace Module2HW2.Model
{
    public interface ICart
    {
        int CartId { get; }
        string SessionId { get;  }
        double Total { get; }
        void Add(ICartItem cartItem);
        void Calculate();
        ICartItem? GetItem();
    }
}

