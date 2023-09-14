var samsung = new Product("Samsung Galaxy A02", 1000);
var apple = new Product("iPhone 6", 1001);

var amazon = new Amazon();
var berkayObserver = new BerkayObserver("Berkay Zaim");
var zaimObserver = new ZaimObserver("Zaim Berkay");

amazon.Register(berkayObserver, samsung);
amazon.Register(zaimObserver, apple);

amazon.NotifyForProductName("iPhone 6");
amazon.NotifyAll();

Console.ReadLine();


class Amazon
{
    private Dictionary<IObserver, Product> observers = new();
    // Buradaki temel mantık, Gözlemcinin gözlediği nesne ile eşleştirilip saklanmasıdır. Bu sayede hedef nesnede aradığımız gözlem gerçekleştiğinde metot aktive olacaktır.

    public void Register(IObserver observer, Product product)
    {
        observers.TryAdd(observer, product);
    }

    public void UnRegister(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyAll()
    {
        foreach (var kv in observers)
        {
            kv.Key.Notify(kv.Value);
        }
    }

    public void NotifyForProductName(string productName)
    {
        foreach (var kv in observers)
        {
            if (kv.Value.Name == productName)
                kv.Key.Notify(kv.Value);
        }
    }
}

interface IObserver
{
    string FullName { get; set; }
    void Notify(Product product);
}

class ZaimObserver : IObserver
{
    public string FullName { get; set; }

    public ZaimObserver(string fullName)
    {
        FullName = fullName;
    }

    public void Notify(Product product)
    {
        Console.WriteLine($"{FullName}, Product {product.Name} in stock now!");
    }
}

class BerkayObserver : IObserver
{
    public string FullName { get; set; }

    public BerkayObserver(string fullName)
    {
        FullName = fullName;
    }

    public void Notify(Product product)
    {
        Console.WriteLine($"{FullName}, Product {product.Name} in stock now!");
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}