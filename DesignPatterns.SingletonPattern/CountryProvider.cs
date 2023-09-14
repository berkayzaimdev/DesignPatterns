using DesignPatterns.SingletonPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class CountryProvider
    {
        private static CountryProvider instance = null;
        public static CountryProvider Instance => instance ?? (instance = new CountryProvider());
            // public static metot, Singleton Pattern'in ana düşüncesini en iyi şekilde yansıtan özelliğidir.
            // Dışarıdan erişime açık olan bu metot ile, her seferinde aynı nesneyi döneceğimiz durumu garanti altına alırız.
            // Eğer metodu ilk kez çağırıyorsak, yeni nesne oluşacaktır. Metodu tekrar çağırdığımızda ise zaten var olan nesne dönecektir.

        private new List<Country> Countries { get; set; }

        private CountryProvider() 
            // private Constructor sayesinde birden fazla sayıda nesne oluşma ihtimalini sıfırlarız.
        {
            Task.Delay(2000).GetAwaiter().GetResult();

            Countries = new List<Country>()
            {
                new Country(){ Name = "Türkiye" },
                new Country(){ Name = "Birleşik Krallık" }
            };
        }

        public int CountryCount => Countries.Count;

        public async Task<List<Country>> GetCountries() => Countries;
    }
}
