using System;
namespace Module2HW2.Entity
{
    public interface ICartItem
    {
        double Price { get;  }
        string Name { get;  }
        string Sku { get;  }
        uint Qty { get; set; }
        IProduct Product { get;  }
        ICartItem Next { get; set; }
    }
}

