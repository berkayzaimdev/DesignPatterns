using DesignPatterns.StrategyPattern.Strategies.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.Strategies.Concrete
{
    public class AttackingStrategy : IGameplayStrategy // Concrete Strategy
    {
        public void Do()
        {
            Console.WriteLine("taş kazanımına ve fedaya yönelik oyun tarzını benimsiyor.");
        }
    }
}
