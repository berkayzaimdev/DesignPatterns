using DesignPatterns.StrategyPattern.Strategies.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.Strategies.Concrete
{
    public class DefencingStrategy : IGameplayStrategy // Concrete Strategy
    {
        public void Do()
        {
            Console.WriteLine("taş korumaya ve eşitliğe yönelik oyun tarzını benimsiyor.");
        }
    }
}
