//Computer computer = new();

//CPU cpu = new CPU();
//computer.Cpu = cpu;

//RAM ram = new RAM();
//computer.Ram = ram;

//VideoCard videoCard = new VideoCard();
//computer.VideoCard = videoCard; 
// bir sınıf, çok kompleks bir yapıdaysa ve parametreleri birer class ise kullanabileceğimiz bir design pattern

ComputerCreator creator = new();
Computer hp = creator.Create(new HpFactory());
Computer lenovo = creator.Create(new LenovoFactory());


class Computer
{
    public ICPU Cpu { get; set; }
    public IRAM Ram { get; set; }
    public IVideoCard VideoCard { get; set; }

    public Computer(CPU cpu, RAM ram, VideoCard videoCard)
    {
        Cpu = cpu;
        Ram = ram;
        VideoCard = videoCard;
    }

    public Computer()
    {
        
    }
}

#region Abstract Products
interface ICPU { }
interface IRAM { }
interface IVideoCard { }
#endregion

#region Concrete Products
class CPU : ICPU 
{
    public CPU(string text)
    {
        Console.WriteLine(text);
    }
}
class RAM : IRAM 
{
    public RAM(string text)
    {
        Console.WriteLine(text);
    }
}
class VideoCard : IVideoCard
{
    public VideoCard(string text)
    {
        Console.WriteLine(text);
    }
}
#endregion

#region Abstract Factory
interface IComputerFactory
{
    ICPU CreateCpu();
    IRAM CreateRam();
    IVideoCard CreateVideoCard();
}
#endregion

#region Concrete Factory
class HpFactory : IComputerFactory
{
    public ICPU CreateCpu()
    {
        return new CPU("HP CPU üretildi");
    }

    public IRAM CreateRam()
    {
        return new RAM("HP RAM üretildi");
    }

    public IVideoCard CreateVideoCard()
    {
        return new VideoCard("HP ekran kartı üretildi");
    }
}

class LenovoFactory : IComputerFactory
{
    public ICPU CreateCpu()
    {
        return new CPU("Lenovo CPU üretildi");
    }

    public IRAM CreateRam()
    {
        return new RAM("Lenovo RAM üretildi");
    }

    public IVideoCard CreateVideoCard()
    {
        return new VideoCard("Lenovo ekran kartı üretildi");
    }
}
#endregion

#region Creator

class ComputerCreator
{
    ICPU cpu;
    IRAM ram;
    IVideoCard videoCard;

    public Computer Create(IComputerFactory computerFactory)
    {
        cpu = computerFactory.CreateCpu();
        ram = computerFactory.CreateRam();
        videoCard = computerFactory.CreateVideoCard();

        return new Computer(cpu as CPU, ram as RAM, videoCard as VideoCard);
    }
}

#endregion