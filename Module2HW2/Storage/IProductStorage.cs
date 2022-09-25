using System;
using Module2HW2.Entity;

namespace Module2HW2.Storage
{
    public interface IProductStorage
    {

        void Add(IProduct product);
        IProduct GetProduct();
    }
}

