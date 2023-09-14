using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Cars
{
    public class BasicCar : Car
    {
        // Soyut sınıftan kalıtım alan bir somut sınıf. Bu sınıfta seçili metot override edilmiştir.
        public override void Assemble()
        {
            Console.Write("I'm a Basic Car.");
        }
    }
}