#region Avantajları
// Global olarak erişim sağlayabiliriz.
// Sadece ihtiyaç olduğu zaman oluştururuz.
#endregion

#region Dezavantajları
// Singleton genellikle kötü bir tasarım kalıbı olarak kabul görmüştür.
// UnitTest'in zorluğu
// Dependency Injection'ın zorluğu
#endregion

using DesignPatterns.SingletonPattern;

var countries1 = await CountryProvider.Instance.GetCountries();

Console.WriteLine(CountryProvider.Instance.CountryCount);

foreach(var country in countries1)
    Console.WriteLine(country.Name);