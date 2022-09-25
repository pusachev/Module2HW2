using System;
using Module2HW2.Entity;

namespace Module2HW2.Model
{
    public class Cart: ICart
    {
        private ICartItem? _head;
        private ICartItem? _current;
        private static int _cartId = 1;

        public int CartId { get; private set; }
        public string SessionId { get; private set; }
        public double Total { get; private set; } = 0.00;

        public Cart(string sessionId)
        {
            CartId = _cartId++;
            SessionId = sessionId;
        }

        public void Add(ICartItem cartItem)
        {
            if (null == _head)
            {
                _head = cartItem;
                _current = _head;
            }
            else
            {
                ICartItem item = _head;
                bool exists = false;

                while (null != item)
                {
                    if (item.Sku == cartItem.Sku)
                    {
                        item.Qty += cartItem.Qty;
                        exists = true;
                        break;
                    }

                    item = item.Next;
                }

                if (!exists)
                {
                    _current.Next = cartItem;
                    _current = _current.Next;
                }
            }
        }

        public void Calculate()
        {
            Total = 0;
            ICartItem? item = GetItem();

            while (null != item)
            {
                Total += item.Price * item.Qty;
                item = item.Next;
            }
        }

        public ICartItem? GetItem()
        {
            return _head;
        }
    }
}

