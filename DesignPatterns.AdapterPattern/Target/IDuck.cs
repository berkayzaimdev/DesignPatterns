using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Target
{
    public interface IDuck
    {
        // Adapte olunacak Interface
        void Quack();
        void Fly();
    }
}
