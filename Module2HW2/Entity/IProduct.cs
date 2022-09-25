using System;
namespace Module2HW2.Entity
{
    public interface IProduct
    {
        string Sku { get;  }
        string Name { get;  }
        double Price { get;  }
    }
}

