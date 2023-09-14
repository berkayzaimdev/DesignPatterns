using DesignPatterns.StrategyPattern.Strategies.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class Player
    {
        public string Name { get; set; }
        private IGameplayStrategy GameplayStrategy;

        public Player(string name, IGameplayStrategy gameplayStrategy)
        {
            Name = name;
            GameplayStrategy = gameplayStrategy;
        }

        public Player()
        {
            
        }

        public void SetGameplayStrategy(IGameplayStrategy gameplayStrategy) 
        {
            GameplayStrategy = gameplayStrategy;
        }

        public void ApplyGameplayStrategy() 
        {
            Console.Write(Name + " ");
            GameplayStrategy.Do();
        }
    }
}
