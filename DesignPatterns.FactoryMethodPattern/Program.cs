using DesignPatterns.FactoryMethodPattern;
using DesignPatterns.FactoryMethodPattern.Models.Abstract;

AnimalFactory animalFactory = new AnimalFactory();

IAnimal a1 = animalFactory.GetAnimal("Chicken");
a1.Sound();

IAnimal a2 = animalFactory.GetAnimal("Elephant");
a2.Sound();

IAnimal a3 = animalFactory.GetAnimal("Dog");
a3.Sound();

// Factory Method Tasarım Kalıbı ile sıfırdan bir nesne üretebiliriz.

// Bir nakliye firması için dizayn yaptığımızı düşünelim.
// İlk başta firmanın yeni açıldığı düşünülürse, tüm planlama kara yolu ile teslimat üzerine kurulacaktır
// Fakat firma büyüdükçe talep de artacağı için ilerleyen etapta deniz ve hava yolları ile de teslimat gerçekleştirmek isteyebiliriz
// Bu sebeple araç bir Interface; kamyon, gemi ve uçak da bu Interface'i implemente eden birer somut sınıf olmalıdır.

// Builder Tasarım Kalıbı ile bir noktada benzerlik gösterir, fakat Builder adım adım işlerken Factory tek seferde nesne üretir.
// Builder'ı yemek yapmak gibi düşünebiliriz. Yemeğin pişme şekli, malzemelerin miktarı, kullanılan soslar ve miktarları değişebilir.
// Factory Method ise hazır yemek almak gibidir. Yemeğe ihtiyacımız olduğu durumda alacağımız yemeği belirleyip dışarıdan alabiliriz.