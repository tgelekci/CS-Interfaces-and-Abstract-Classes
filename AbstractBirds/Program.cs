using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBirds
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            GoldenEagle ge1 = new GoldenEagle(2.50, 30, true, "North America", 4.7, "Dark Brown, Golden");
            Console.WriteLine("GOLDEN EAGLE\n" + "Lifespan: " + ge1.Lifespan + " years\nHabitat: " + ge1.Habitat + "\nColor: " + ge1.Color + "\nAverage Weight: " + ge1.AverageWeight+" kg\nWingspan: "+ge1.Wingspan+" m\nCan it fly?: "+ge1.CanItFly);
            ge1.Diet();
            ge1.Enemies();

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Penguin p1 = new Penguin(0.8, 20, false, "South America, New Zealand, Australia, Africa, Antartica", 17.3, "Black, White");
            Console.WriteLine("PENGUIN\n" + "Lifespan: " + p1.Lifespan + " years\nHabitat: " + p1.Habitat + "\nColor: " + p1.Color + "\nAverage Weight: " + p1.AverageWeight + " kg\nWingspan: " + p1.Wingspan + " m\nCan it fly?: " + p1.CanItFly);
            p1.Diet();
            p1.Enemies();

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Ostrich o1 = new Ostrich(2.0, 40, false, "Africa", 130.0, "Black, Brown, White");
            Console.WriteLine("OSTRICH\n" + "Lifespan: " + o1.Lifespan + " years\nHabitat: " + o1.Habitat + "\nColor: " + o1.Color + "\nAverage Weight: " + o1.AverageWeight + " kg\nWingspan: " + o1.Wingspan + " m\nCan it fly?: " + o1.CanItFly);
            o1.Diet();
            o1.Enemies();

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Red;

            Seagull s1 = new Seagull(0.12, 15, true, "North and South America, the Caribbean, Europe, Australia, islands around Antarctica", 2.0, "White, Gray");
            Console.WriteLine("SEAGULL\n" + "Lifespan: " + s1.Lifespan + " years\nHabitat: " + s1.Habitat + "\nColor: " + s1.Color + "\nAverage Weight: " + s1.AverageWeight + " kg\nWingspan: " + s1.Wingspan + " m\nCan it fly?: " + s1.CanItFly);
            s1.Diet();
            s1.Enemies();

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Pigeon pi1 = new Pigeon(0.68, 15, true, "Worldwide except Sahara Desert, Antarctica and the high Arctic", 0.3, "White, Gray, Black");
            Console.WriteLine("PIGEON\n" + "Lifespan: " + pi1.Lifespan + " years\nHabitat: " + pi1.Habitat + "\nColor: " + pi1.Color + "\nAverage Weight: " + pi1.AverageWeight + " kg\nWingspan: " + pi1.Wingspan + " m\nCan it fly?: " + pi1.CanItFly);
            pi1.Diet();
            pi1.Enemies();

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }
    }
}
