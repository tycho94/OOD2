using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GogoFamis
{
    class Connection
    {

        public Location FirstLoc;
        public Location SecondLoc;
        public double KilometerDistance;


        public Connection(Location l1, Location l2, double dist) {
            this.FirstLoc = l1;
            this.SecondLoc = l2;
            this.KilometerDistance = dist;
        }

    }
}
