using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBirds
{
    abstract class Bird
    {
        public double Wingspan;
        public int Lifespan;
        public Boolean CanItFly;
        public string Habitat;
        public double AverageWeight;
        public string Color;
        
        public abstract void Enemies();
        public abstract void Diet();
    }
}
