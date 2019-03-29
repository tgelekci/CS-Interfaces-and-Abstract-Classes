using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBirds
{
    class GoldenEagle : Bird
    {
        public GoldenEagle(double wingspan, int lifespan, Boolean canItFly, string habitat, double avgweight, string color)
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
            Console.WriteLine("Diet:Rabbits, Marmots, Squirrels, Carrions, Reptiles, Other Birds, Fishes, Large Insects");
        }

        public override void Enemies()
        {
            Console.WriteLine("Natural Enemies:Humans(Farmers), Bears, Wolves");
        }

      
    }
}
