var tasks = new List<Task>();

for (int i = 0; i < 100; i++)
{
    tasks.Add(Task.Run(() => Example.Instance));
}

var t3 = Task.Run(() => Example.Instance);
var t4 = Task.Run(() => Example.Instance);

await Task.WhenAll(tasks);

class Example
{
    private Example()
    {
        Console.WriteLine("instance üretildi!");
    }

    static Example _example;
    static object _obj = new object();

    static public Example Instance
    {
        get
        {
            lock (_obj)
            {
                if (_example == null)
                    _example = new Example();
            }

            return _example;
        }
    }
}