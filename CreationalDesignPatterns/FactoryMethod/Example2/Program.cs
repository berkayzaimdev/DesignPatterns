while (true)
{
    for (int i = 0; i < 100; i++)
    {
        try
        {
            A a = ProductFactory.GetInstance(ProductType.A) as A;

            B b = ProductFactory.GetInstance(ProductType.B) as B;

            C c = ProductFactory.GetInstance(ProductType.C) as C;
        }
        catch (Exception)
        {

            throw;
        }
    }
}

#region Abstract Product
interface IProduct
{
}

#endregion

class A : IProduct
{
    public A()
    {
        Console.WriteLine("A üretildi");
    }
}

class B : IProduct
{
    public B()
    {
        Console.WriteLine("B üretildi");
    }
}

class C : IProduct
{
    public C()
    {
        Console.WriteLine("C üretildi");
    }
}

#region Abstract Factory
interface IFactory
{
    IProduct CreateProduct();
}

#endregion

#region Concrete Factories
class AFactory : IFactory
{
    public IProduct CreateProduct()
    {
        A a = new A();
        return a;
    }
}

class BFactory : IFactory
{
    public IProduct CreateProduct()
    {
        B b = new B();
        return b;
    }
}

class CFactory : IFactory
{
    public IProduct CreateProduct()
    {
        C c = new C();
        return c;
    }
}

#endregion

#region Factory

enum ProductType
{
    A,
    B,
    C
}

class ProductFactory
{
    public static IProduct GetInstance(ProductType productType)
    {
        IFactory _factory = productType switch
        {
            ProductType.A => new AFactory(),
            ProductType.B => new BFactory(),
            ProductType.C => new CFactory(),
            _ => throw new NotImplementedException()
        };

        return _factory.CreateProduct();
    }
}

#endregion