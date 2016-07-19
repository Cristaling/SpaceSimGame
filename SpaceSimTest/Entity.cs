using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceSimTest
{
    class Entity
    {

        Location origin;
        Velocity velocity;

        public Entity(Location origin)
        {
            this.origin = origin;
        }

        public Location getLocation()
        {
            return origin;
        }

    }
}
