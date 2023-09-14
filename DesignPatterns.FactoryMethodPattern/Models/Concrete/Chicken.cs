using DesignPatterns.FactoryMethodPattern.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Models.Concrete
{
    public class Chicken : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("I sound 'cluck cluck cluck' as a Chicken");
        }
    }
}
