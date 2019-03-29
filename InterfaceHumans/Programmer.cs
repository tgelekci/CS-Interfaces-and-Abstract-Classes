using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHumans
{
    class Programmer : IHuman //implementing interface explicitly 
    {
        void IHuman.Eat()
        {
            Console.WriteLine("The programmer eats from the restaurant.");

        }

        void IHuman.Sleep()
        {
            Console.WriteLine("The programmer sleeps at 01.00.");

        }

        void IHuman.WakeUp()
        {
            Console.WriteLine("The programmer wakes up at 07.30.");
        }

        void IHuman.Work()
        {
            Console.WriteLine("The programmer works at the office.");

        }
    }
}
