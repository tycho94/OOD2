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
        private void ShortestCal(Location origin, Location destination, Graphics gr)
        {
            Calculation cal = new Dijkstra(this);
            var result = cal.Calculate(origin, destination, LocationList);
            if (result != null)
            {
                DrawRoutes(result, gr);
            }
        }
        public void DrawRoutes(Route route, Graphics gr)
        {
            // draw lines
            for (int i = 0; i < route.Cities.Count - 1; i++)
            {
                gr.DrawLine(new Pen(Color.Red), route.Cities[i].Coordinates.X, route.Cities[i].Coordinates.Y, route.Cities[i + 1].Coordinates.X, route.Cities[i + 1].Coordinates.Y);
            }
            // draw origin
            DrawCity(gr, route.Cities, new SolidBrush(Color.Red));
            // draw destination
            DrawCity(gr, route.Cities, new SolidBrush(Color.GreenYellow));
        }

        public void DrawCity(Graphics gr, List<Location> loclist, Brush brush)
        {
            foreach (Location l in loclist)
            {

                gr.FillEllipse(brush, l.Coordinates.X - 5, l.Coordinates.Y - 5, 10, 10);
                gr.DrawString(l.Name, new Font("Arial", 6), Brushes.Black, new Point(l.Coordinates.X + 5, l.Coordinates.Y));
            }
        }

        public void DrawCon(Graphics gr, List<Connection> conlist)
        {
            foreach (Connection c in conlist)
            {
                gr.DrawLine(new Pen(Brushes.Black), c.Loc1.Coordinates, c.Loc2.Coordinates);
            }

        }

        //public List<Location> CalculateRoute(Location start, Location dest, Route route, List<Connection> conlist, List<Location> loclist)
        //{
        //    List<Location> loclist;

        //    return loclist;
        //}




    }
}
