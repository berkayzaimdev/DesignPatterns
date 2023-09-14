using DesignPatterns.DecoratorPattern.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    public abstract class CarDecorator : Car
    {
        // Bu sınıf, kendisinden türeteceğimiz Decorator'lar için bir temel oluşturur.
        protected Car Car { get; set; }

        public CarDecorator(Car _car)
        {
            Car = _car;
        }

        public override void Assemble() 
        {
            Car.Assemble();
        }
    }
}