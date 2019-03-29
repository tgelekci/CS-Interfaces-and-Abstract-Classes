using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBirds
{
    class Pigeon : Bird
    {

        public Pigeon(double wingspan, int lifespan, Boolean canItFly, string habitat, double avgweight, string color)
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
            Console.WriteLine("Diet:Seeds, Cereal Grains, Corn, Wheat, Oat, Barley, Pulse, Rye, Peas, Vetch, Millet, Fruits, Insects, Worms, Vegetables, Small Reptiles");

        }

        public override void Enemies()
        {
            Console.WriteLine("Natural Enemies:Cats, Foxes, Birds of Prey(Hawks etc.), Rats, Snakes");

        }
    }
}
