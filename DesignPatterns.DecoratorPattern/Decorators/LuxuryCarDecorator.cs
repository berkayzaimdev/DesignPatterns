using DesignPatterns.DecoratorPattern.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    public class LuxuryCarDecorator : CarDecorator
    {
        public LuxuryCarDecorator(Car _car) : base(_car)
        {
        }

        public override void Assemble()
        {
            // Decorator mantığı gereği bağlı olduğu temel sınıfın metodunu her zaman uygulamalı, ondan sonra ise metodun kendi özelleşmiş hali devreye girmelidir.
            base.Assemble();
            Console.Write(" I'm also a Luxury Car.");
        }
    }
}