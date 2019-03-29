using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHumans
{
    class Worker : IHuman
    {
        public void Eat()
        {
            Console.WriteLine("The worker eats from the refectory.");

        }

        public void Sleep()
        {
            Console.WriteLine("The worker sleeps at 00.00.");

        }

        public void WakeUp()
        {
            Console.WriteLine("The worker wakes up at 07.00.");
        }

        public void Work()
        {
            Console.WriteLine("The worker works at the factory.");
        }
    }
}
