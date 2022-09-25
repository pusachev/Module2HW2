using System;
using Module2HW2.Entity;

namespace Module2HW2.Model
{
    public class Order : IOrder
    {
        private static int _orderId = 1;
        private string _orderPrefix = "S00000";
        public double Total { get; private set; }
        public string OrderId { get => $"{_orderPrefix}{_orderId++}"; }
        public ICartItem CartItem { get;  }

        public Order(ICartItem cartItem)
        {
            CartItem = cartItem;
        }

        public void Calculate()
        {
            Total = 0;
            ICartItem? item = CartItem;

            while (null != item)
            {
                Total += item.Price * item.Qty;
                item = item.Next;
            }
        }
    }
}

