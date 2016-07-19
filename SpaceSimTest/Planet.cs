using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceSimTest
{
    class Planet : Entity
    {

        double radius = 10;

        public Planet(Location origin) : base(origin)
        {
            
        }

        public double getRadius()
        {
            return radius;
        }
        
    }
}
