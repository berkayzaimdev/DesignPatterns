using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.Strategies.Abstract
{
    public interface IGameplayStrategy // Concrete Strategy sınıfları için temel oluşturan Interface
    {
        void Do();
    }
}
