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

        //public void ChangeColor(Location p1, Location p2, bool color);

        //public void CalculateRoute(Location start, Location dest, Route route);

        //public void DrawLine(Location p1, Location p2, Graphics gr);




    }
}
