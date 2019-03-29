using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHumans
{
    class Program
    {
        static void Main(string[] args)
        {
            IHuman i1 = new Student();   //Student sınıfının bellekte bir örneğini oluşturup, arayüze aktarma yaptık.(Çokbiçimcilik)
            i1.WakeUp();
            i1.Work();
            i1.Eat();
            i1.Sleep();

            Console.WriteLine();

            i1 = new Worker();
            i1.WakeUp();
            i1.Work();
            i1.Eat();
            i1.Sleep();

            Console.WriteLine();

            i1 = new Programmer();
            i1.WakeUp();
            i1.Work();
            i1.Eat();
            i1.Sleep();




            Console.ReadKey();
        }
    }
}
