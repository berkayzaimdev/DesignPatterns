while (true)
{
    for (global::System.Int32 i = 0; i < 100; i++)
    {
        try
        {
            A a = ProductFactory.GetInstance(ProductType.A) as A;
            a.Run();

            B b = ProductFactory.GetInstance(ProductType.B) as B;
            b.Run();

            C c = ProductFactory.GetInstance(ProductType.C) as C;
            c.Run();
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
    void Run();
}

#endregion

#region Concrete Products
class A : IProduct
{
    public void Run()
    {
        throw new NotImplementedException();
    }
}

class B : IProduct
{
    public void Run()
    {
        throw new NotImplementedException();
    }
}

class C : IProduct
{
    public void Run()
    {
        throw new NotImplementedException();
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
        switch (productType)
        {
            case ProductType.A:
                return new A();
            case ProductType.B:
                return new B();
            case ProductType.C:
                return new C();
            default:
                return default;
        }
    }
}

#endregion