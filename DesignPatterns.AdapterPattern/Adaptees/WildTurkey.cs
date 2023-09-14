using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Adaptees
{
    public class WildTurkey : ITurkey
    {
        // Adapte edilecek Interface'in somut bir nesnesi
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble gobble!");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance.");
        }
    }
}
