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
        /// Connection
        /// </summary>
        /// <param name="l1">one of the two locations the connection is connected to</param>
        /// <param name="l2">one of the two locations the connection is connected to</param>
        /// <param name="dist">the distance from location to location</param>
        public Connection(Location l1, Location l2, double dist) {
            this.FirstLoc = l1;
            this.SecondLoc = l2;
            this.KilometerDistance = dist;
        }

    }
}
