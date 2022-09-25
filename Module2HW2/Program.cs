// See https://aka.ms/new-console-template for more information

using Module2HW2.Entity;
using Module2HW2.Factory;
using Module2HW2.Model;
using Module2HW2.Storage;
using System.Diagnostics;

Guid uuid = Guid.NewGuid();
int size = 10;
Random rnd = new Random();
IProductFactory productFactory = new ProductFactory();
ICartItemFactory cartItemFactory = new CartItemFactory();
IProductStorage productStorage = new ProductStorage(size);
ICart cart = new Cart(uuid.ToString());

for (int i = 0; i < size; i++)
{
    string sku = "P00" + i.ToString();
    string name = "Product_" + i.ToString();
    double price = rnd.NextDouble() * 99;

    productStorage.Add(productFactory.Create(sku, name, price));
}

for (int i = 0; i < 10; i++)
{
    cart.Add(cartItemFactory.Create(productStorage.GetProduct()));
}

cart.Calculate();
ICartItem? current = cart.GetItem();

Console.WriteLine($"Cart with id: {cart.CartId} and Session: {cart.SessionId}");

while (null !=  current)
{
    Console.WriteLine($"{current.Name} : {current.Price:C2} ({current.Qty})");

    current = current.Next;
}

Console.WriteLine($"Total: {cart.Total:C2}");

if (null != cart.GetItem())
{
    IOrder order = new Order(cart.GetItem());
    order.Calculate();

    Console.WriteLine("\nOrder created");
    Console.WriteLine($"Order #{order.OrderId}");
    Console.WriteLine($"Order total: {order.Total:C2}");
}

Console.ReadLine();