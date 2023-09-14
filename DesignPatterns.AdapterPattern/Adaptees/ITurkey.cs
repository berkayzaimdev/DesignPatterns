using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Adaptees
{
    public interface ITurkey
    {
        // Adapte edilecek Interface
        void Gobble();
        void Fly();
    }
}
