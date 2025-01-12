MySingleton s1 = MySingleton.Instance;
MySingleton s2 = MySingleton.Instance;
MySingleton s3 = MySingleton.Instance;
MySingleton s4 = MySingleton.Instance;
MySingleton s5 = MySingleton.Instance;
MySingleton s6 = MySingleton.Instance;
MySingleton s7 = MySingleton.Instance;
MySingleton s8 = MySingleton.Instance;
MySingleton s9 = MySingleton.Instance;

class MySingleton
{
    private MySingleton()
    {
        Console.WriteLine($"{nameof(MySingleton)} nesnesi oluşturuldu!");
    }

    static MySingleton()
    {
        _mySingleton = new MySingleton();
    }

    static MySingleton _mySingleton;

    public static MySingleton Instance
    {
        get 
        {
            #region 1. Yöntem
            if (_mySingleton == null)
            {
                return new MySingleton();
            }
            return _mySingleton;
            #endregion
            #region 2. Yöntem
            return _mySingleton;
            #endregion
        }
    }
}