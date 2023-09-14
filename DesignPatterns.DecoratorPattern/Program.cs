using DesignPatterns.DecoratorPattern.Cars;
using DesignPatterns.DecoratorPattern.Decorators;

Car sportsCar = new SportsCarDecorator(new BasicCar());
sportsCar.Assemble();

Console.WriteLine();

Car sportsLuxuryCar = new LuxuryCarDecorator(new SportsCarDecorator(new BasicCar()));
sportsLuxuryCar.Assemble();

// Decorator Pattern'e gündelik hayattan bir örnek verecek olursak, kahve makinesi örneğini verebiliriz.
// Makineden en başta sade kahve alırız. Karamel, ekstra şeker, ekstra süt; isteğimize göre diğer seçenekleri sırayla seçer ve uygularız.
// Sade kahve, BasicCar'ın bir temsilidir. Karamel eklemek için örneğin CaramelCoffeeDecorator isminde bir sınıfın yardımıyla "Karamel Eklenmiş Sade Kahve" oluşturabiliriz.