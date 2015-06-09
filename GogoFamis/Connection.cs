using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GogoFamis
{
    class Connection
    {
        //fields
        public Location Loc1;
        public Location Loc2;
        public double KilometerDistance;
        /// <summary>
        /// Connection constructor(used in map constructor)
        /// </summary>
        /// <param name="loc1">the location1 it is connected to</param>
        /// <param name="loc1">the location2 it is connected to</param>
        /// <param name="dist">the distance from location to location</param>
        public Connection(Location loc1, Location loc2, double dist) {
            this.Loc1 = loc1;
            this.Loc2 = loc2;
            this.KilometerDistance = dist;
        }
    

    }
}
