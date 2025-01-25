BankCreator bankCreator = new();
AlbarakaBank? albaraka = bankCreator.Create(BankType.Albaraka) as AlbarakaBank;
KuveytturkBank? kuveytturk = bankCreator.Create(BankType.Kuveytturk) as KuveytturkBank;
VakifBank? vakif = bankCreator.Create(BankType.Vakif) as VakifBank;

AlbarakaBank? albaraka2 = bankCreator.Create(BankType.Albaraka) as AlbarakaBank;
KuveytturkBank? kuveytturk2 = bankCreator.Create(BankType.Kuveytturk) as KuveytturkBank;
VakifBank? vakif2 = bankCreator.Create(BankType.Vakif) as VakifBank;

AlbarakaBank? albaraka3 = bankCreator.Create(BankType.Albaraka) as AlbarakaBank;
KuveytturkBank? kuveytturk3 = bankCreator.Create(BankType.Kuveytturk) as KuveytturkBank;
VakifBank? vakif3 = bankCreator.Create(BankType.Vakif) as VakifBank;

#region Abstract Products

interface IBank
{
    
}

#endregion

#region Concrete Products
class AlbarakaBank : IBank
{
    string _userCode, _password;

    AlbarakaBank(string userCode, string password)
    {
        _userCode = userCode;
        _password = password;
    }

    static AlbarakaBank() => _albarakaBank = new("test","123");
    static AlbarakaBank _albarakaBank;
    public static AlbarakaBank GetInstance => _albarakaBank;

    public void ConnectAlbaraka() => Console.WriteLine($"{nameof(AlbarakaBank)} - connected");
    public void SendMoney(int amount) => Console.WriteLine($"{amount} money sent");
}

class KuveytturkBank : IBank
{
    string _userCode;
    public string _password;
    KuveytturkBank(string userCode)
    {
        _userCode = userCode;
        Console.WriteLine($"{nameof(KuveytturkBank)} olusturuldu");
    }
    static KuveytturkBank() => _kuveytturkBank = new("test");
    static KuveytturkBank _kuveytturkBank;
    public static KuveytturkBank GetInstance => _kuveytturkBank;

    public void Send(int amount, string accountNumber) => Console.WriteLine($"{amount} money sent to {accountNumber}");
}

class CredentialVakifBank
{
    public string UserCode, Mail;

    public CredentialVakifBank(string userCode, string mail)
    {
        UserCode = userCode;
        Mail = mail;
    }
}

class VakifBank : IBank
{
    string _userCode, _email, _password;
    public bool IsAuthenticated { get; private set; }

    VakifBank(CredentialVakifBank credential, string password)
    {
        _userCode = credential.UserCode;
        _email = credential.Mail;
        _password = password;
        Console.WriteLine($"{nameof(VakifBank)} olusturuldu");
    }

    static VakifBank() => _vakifBank = new(new("test", "test@com"), "123");
    static VakifBank _vakifBank;
    public static VakifBank GetInstance => _vakifBank;

    public void ValidateCredential()
    {
        if (true)
        {
            IsAuthenticated = true;
        }

        IsAuthenticated = false;
    }

    public void SendMoneyToAccountNumber(int amount, string recipientName, string accountNumber) => Console.WriteLine($"{amount} money sent to {accountNumber}");
}

#endregion

#region Abstract Factory

interface IBankFactory
{
    IBank CreateInstance();
}

#endregion

#region Concrete Factory

class AlbarakaFactory : IBankFactory
{
    AlbarakaFactory() { }
    static AlbarakaFactory() => _albarakaFactory = new();
    static AlbarakaFactory _albarakaFactory;
    public static AlbarakaFactory GetInstance => _albarakaFactory;

    public IBank CreateInstance()
    {
        AlbarakaBank albaraka = AlbarakaBank.GetInstance;
        albaraka.ConnectAlbaraka();
        return albaraka;
    }
}

class KuveytturkFactory : IBankFactory
{
    KuveytturkFactory() { }
    static KuveytturkFactory() => _kuveytturkFactory = new();
    static KuveytturkFactory _kuveytturkFactory;
    public static KuveytturkFactory GetInstance => _kuveytturkFactory;

    public IBank CreateInstance()
    {
        KuveytturkBank kuveytturk = KuveytturkBank.GetInstance;
        kuveytturk._password = "456";
        return kuveytturk;
    }
}

class VakifFactory : IBankFactory
{
    VakifFactory() { }
    static VakifFactory() => _vakifFactory = new();
    static VakifFactory _vakifFactory;
    public static VakifFactory GetInstance => _vakifFactory;
    public IBank CreateInstance()
    {
        VakifBank vakif = VakifBank.GetInstance;
        vakif.ValidateCredential();
        return vakif;
    }
}

#endregion

#region Creator

enum BankType
{
    Albaraka,
    Kuveytturk,
    Vakif
}

class BankCreator
{
    public IBank Create(BankType bankType)
    {
        IBankFactory _bankFactory = bankType switch
        {
            BankType.Albaraka => AlbarakaFactory.GetInstance,
            BankType.Kuveytturk => KuveytturkFactory.GetInstance,
            BankType.Vakif => VakifFactory.GetInstance,
            _ => throw new NotImplementedException()
        };

        return _bankFactory.CreateInstance();
    }
}

#endregion