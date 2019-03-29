using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHumans
{
    class Student : IHuman
    {
        public void Eat()
        {
            Console.WriteLine("The student eats from the canteen.");
        }

        public void Sleep()
        {
            Console.WriteLine("The student sleeps at 23.00.");
        }

        public void WakeUp()
        {
            Console.WriteLine("The student wakes up at 08.00.");
        }

        public void Work()
        {
            Console.WriteLine("The student studies at the school.");
        }
    }
}
