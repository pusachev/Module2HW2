using System;
using Module2HW2.Entity;

namespace Module2HW2.Factory
{
    public interface IProductFactory
    {
        IProduct Create(string sku, string name, double price);
    }
}
