using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBirds
{
    class Ostrich : Bird
    {
        public Ostrich(double wingspan, int lifespan, Boolean canItFly, string habitat, double avgweight, string color)
        {

            Wingspan = wingspan;
            Lifespan = lifespan;
            CanItFly = canItFly;
            Habitat = habitat;
            AverageWeight = avgweight;
            Color = color;
        }
        public override void Diet()
        {
            Console.WriteLine("Diet:Fallen Fruits, Seeds, Shrubs, Shoots, Gourds, Dry and Hard Foliage, Frogs, Roots, Plants, Tortoises, Tiny Lizards, Bugs");
        }

        public override void Enemies()
        {
            Console.WriteLine("Natural Enemies:Cheetahs, Lions, Leopards, Hyenas, African Wild Dogs");
        }
    }
}
