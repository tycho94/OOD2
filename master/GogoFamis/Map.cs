using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GogoFamis
{
    class Map
    {

        public List<Location> LocationList;
        public List<Connection> ConnectionList;

        public Map(List<Location> LocList, List<Connection> ConList)
        {
            this.LocationList = LocList;
            this.ConnectionList = ConList;
        }
        public Map(List<Location> LocList)
        {
            this.LocationList = LocList;
        }

        public void ChangeColor(List<Location> loclist)
        {

        }

        //public List<Location> CalculateRoute(Location start, Location dest, Route route, List<Connection> conlist, List<Location> loclist)
        //{
        //    List<Location> loclist;

        //    return loclist;
        //}




    }
}
