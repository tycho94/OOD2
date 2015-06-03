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
        private List<Connection> ConnectionList;

        public Map(List<Location> LocList, List<Connection> ConList) 
        { this.LocationList = LocList;
        this.ConnectionList = ConList;
        }

        public void ChangeColorConnection(Point p1, Point p2, bool color);

        public bool CalculateRoute(Point start, Point des, Algorithm alg);

        public void DrawLine(Point p1, Point p2);
        public void ClearLine(Point p1, Point p2)
        ;

        public Point CalculateRouteArray(string alg);



    }
}
