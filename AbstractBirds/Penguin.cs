using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBirds
{
    class Penguin : Bird
    {
        public Penguin(double wingspan, int lifespan, Boolean canItFly, string habitat, double avgweight, string color)
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
            Console.WriteLine("Diet:Krill, Fishes, Squids");
        }

        public override void Enemies()
        {
            Console.WriteLine("Natural Enemies:Humans, Orcas, Sharks, Leopard Seals, Skuas, Lizards, Snakes, Ferrets");
        }
    }
}
