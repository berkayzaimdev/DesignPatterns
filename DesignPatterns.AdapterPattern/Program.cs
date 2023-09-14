using DesignPatterns.AdapterPattern.Adaptees;
using DesignPatterns.AdapterPattern.Adapter;
using DesignPatterns.AdapterPattern.Target;

WildTurkey Turkey = new WildTurkey();
IDuck TurkeyAdapter = new TurkeyAdapter(Turkey);
Console.WriteLine("The Turkey says...");
Turkey.Gobble();
Turkey.Fly();

Console.WriteLine("\nThe TurkeyAdapter says...");
TestDuck(TurkeyAdapter);

static void TestDuck(IDuck Duck)
{
    Duck.Quack();
    Duck.Fly();
    // Uyguladığımız Adapter Pattern sayesinde Turkey Interface'i artık Duck Interface'i ile uyumlu bir şekilde işlev sağlayabilmektedir.
}