using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Cars
{
    public abstract class Car
    {
        // Decorator Pattern'i uygulamak için hedef sınıfımızın soyut versiyonunu oluşturmalıyız. Bu sınıftan türeyen sınıflar, seçili metodu override etmeli.
        public abstract void Assemble();
    }
}