using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceSimTest
{
    class Location
    {

        double x;
        double y;

        public Location(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getDistance(Location target)
        {
            return Math.Sqrt(Math.Pow(target.x - x, 2) + Math.Pow(target.y - y, 2));
        }

    }
}
