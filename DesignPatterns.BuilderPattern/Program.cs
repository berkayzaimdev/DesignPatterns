using DesignPatterns.BuilderPattern.Method1;
using DesignPatterns.BuilderPattern.Method2;
using System.Text;

#region Sample Builder

#region Without Builder
var sb = new StringBuilder();

sb.Append("Berkay").Append(" ").Append("Zaim");
sb.Append(" Zaim");

var fullname = sb.ToString();
#endregion



#region With Builder
var eb = new EndpointBuilder("https://localhost");
eb
    .Append("api")
    .Append("v1")
    .Append("user")
    .AppendParam("id", "5")
    .AppendParam("username", "berkay");
var url = eb.Build();

// Console.WriteLine("Final URL: "+url);

//Burada örnek bir Builder oluşturduk. URL üreten basit bir class olarak karşımıza çıkıyor, fakat farklı farklı URL'ler üretmek istediğimi zaman tıkanırız.
//Bunu MMORPG türündeki bir oyunda karakter oluşturmak gibi düşünebiliriz. İnsan ırkını seçtiysek sınıflar ve karşılaştığımız görevler farklı olur, Elf ırkını seçtiysek farklı olur gibi türetebiliriz.
//Fakat sınıf ve görev sistemi hep aynıdır. Factory tasarım desenindeki ana hedef; temelde aynı işi yapan fakat bir noktada dallara ayrılan sınıfları pratik bir şekilde oluşturmak ve yönetmektir.
#endregion

#endregion



#region Multiple Builders

#region With Sample Builder

var empBuilder = new EmployeeBuilderM1();
var employee = empBuilder
    .SetFullName("Berkay Zaim")
    .SetUserName("berkayzaim")
    .SetEmailAddress("berkayzaim@mail.com")
    .BuildEmployee();
// Console.WriteLine(employee.ToString());

#endregion



#region With Base Builder

var emp = GenerateEmployee("Berkay Zaim", "berkayzaim@mail.com", 1);
Console.WriteLine("Email Address: " + emp.EmailAddress);

EmployeeM2 GenerateEmployee(string fullName, string emailAddress, int empType)
{
    IEmployeeBuilderM2 employeeBuilder;
    if (empType == 0)
        employeeBuilder = new InternalEmployeeBuilder();
    else
        employeeBuilder = new ExternalEmployeeBuilder();

    employeeBuilder.SetFullName(fullName);
    employeeBuilder.SetEmailAddress(emailAddress);

    return employeeBuilder.BuildEmployee();
}
// Ek bir metot yazarak Builder tasarım desenini tam manasıyla çalıştırabildik. Üretim için int tipinde bir değişkene ihtiyaç duyduk. Bu değişken bizim hangi Builder'e gideceğimizi belirliyor.
// Internal'a gitseydik de aynı metotları uygulayacaktık fakat metotların birbirinden farklı işlemleri de uygulanacaktı.

#region Without Additional Function

//IEmployeeBuilderM2 employeeBuilder = new InternalEmployeeBuilder();

//employeeBuilder.SetEmailAddress("berkayzaim@mail.com");
//employeeBuilder.SetFullName("Berkay Zaim");

//var emp = employeeBuilder.BuildEmployee();
//Console.WriteLine("Email address: " + emp.EmailAddress);
#endregion

#endregion

#endregion