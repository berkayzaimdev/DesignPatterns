using DesignPatterns.FactoryMethodPattern.Models.Abstract;
using DesignPatterns.FactoryMethodPattern.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    public class AnimalFactory
    {
        public IAnimal GetAnimal(String animalSpecy)
        {
            switch(animalSpecy) 
            {
                case "Chicken":
                    return new Chicken();
                case "Elephant":
                    return new Elephant();
                case "Dog":
                    return new Dog();
                default:
                    return null;
            }
        }
    }
}
