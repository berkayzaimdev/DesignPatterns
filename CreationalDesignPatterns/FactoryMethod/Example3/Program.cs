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

    public AlbarakaBank(string userCode, string password)
    {
        _userCode = userCode;
        _password = password;
    }

    public void ConnectAlbaraka() => Console.WriteLine($"{nameof(AlbarakaBank)} - connected");
    public void SendMoney(int amount) => Console.WriteLine($"{amount} money sent");
}

class KuveytturkBank : IBank
{
    string _userCode;
    public string _password;
    public KuveytturkBank(string userCode)
    {
        _userCode = userCode;
        Console.WriteLine($"{nameof(KuveytturkBank)} olusturuldu");
    }

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

    public VakifBank(CredentialVakifBank credential, string password)
    {
        _userCode = credential.UserCode;
        _email = credential.Mail;
        _password = password;
        Console.WriteLine($"{nameof(VakifBank)} olusturuldu");
    }

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
    public IBank CreateInstance()
    {
        AlbarakaBank albaraka = new("test1", "123");
        albaraka.ConnectAlbaraka();
        return albaraka;
    }
}

class KuveytturkFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        KuveytturkBank kuveytturk = new("test2");
        kuveytturk._password = "456";
        return kuveytturk;
    }
}

class VakifFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        VakifBank vakif = new(new("test3", "test@test.com"), "789");
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
            BankType.Albaraka => new AlbarakaFactory(),
            BankType.Kuveytturk => new KuveytturkFactory(),
            BankType.Vakif => new VakifFactory(),
            _ => throw new NotImplementedException()
        };

        return _bankFactory.CreateInstance();
    }
}

#endregion