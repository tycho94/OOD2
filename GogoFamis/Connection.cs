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
        public Location FirstLoc;
        public Location SecondLoc;
        public double KilometerDistance;
        /// <summary>
        /// Connection constructor
        /// </summary>
        /// <param name="loc1">one of the two locations the connection is connected to</param>
        /// <param name="loc2">one of the two locations the connection is connected to</param>
        /// <param name="dist">the distance from location to location</param>
        public Connection(Location loc1, Location loc2, double dist) {
            this.FirstLoc = loc1;
            this.SecondLoc = loc2;
            this.KilometerDistance = dist;
        }
    

    }
}
