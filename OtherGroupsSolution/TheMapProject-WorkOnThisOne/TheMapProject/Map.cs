using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TheMapProject
{
    public class Map
    {
        private List<City> _cities;
        private Calculation _cal;
        private FileHandler _file;
        private Point dimentions;
        Brush _myBrush;
        Pen _myPen;

        public Map(string filename)
        {
            _cities = new List<City>();
            _file = new FileHandler(filename);
        }

        public Point Dimentions
        {
            get { return dimentions; }
            private set { }
        }
        public List<City> Cities
        {
            get { return _cities; }
            private set { }
        }

        // draw map after loading file
        public void DrawMap(Graphics gr)
        {
            _myBrush = new SolidBrush(Color.Black);
            _myPen = new Pen(Color.Black);
            foreach (City a in Cities)
            {
                DrawCity(a, gr, _myBrush);
                DrawConnection(a, gr, _myPen);
                WriteCityName(gr, a);
            }
        }
        public void DrawCity(City city, Graphics gr, Brush brush)
        {
            gr.FillEllipse(brush, city.X - 3, city.Y - 3, 8, 8);
        }

        private void DrawConnection(City city, Graphics b, Pen myPen)
        {
            foreach (Connection a in city.Connections)
            {
                b.DrawLine(myPen, city.X, city.Y, a.City.X, a.City.Y);
            }
        }
        // Draw routes after choosing methods
        private void DrawRoutes(Route route, Graphics gr)
        {
            // draw map
            DrawMap(gr);
            _myPen = new Pen(Color.Red);
            // draw lines
            for (int i = 0; i < route.Stations.Count - 1; i++)
            {
                gr.DrawLine(_myPen, route.Stations[i].X, route.Stations[i].Y, route.Stations[i + 1].X, route.Stations[i + 1].Y);
            }
            // draw origin
            _myBrush = new SolidBrush(Color.Red);
            DrawCity(route.Stations[0], gr, _myBrush);
            // draw destination
            _myBrush = new SolidBrush(Color.GreenYellow);
            DrawCity(route.Stations[route.Stations.Count - 1], gr, _myBrush);
        }

        private void WriteCityName(Graphics gr, City c)
        {
            Font myFont = new Font("Arial", 10);
            _myBrush = new SolidBrush(Color.Brown);
            gr.DrawString(c.Name, myFont, _myBrush, new Point(c.X - 15, c.Y));


        }


        // calculate the least stop
        public void LeastStopCal(City origin, City destination, Graphics gr)
        {
            _cal = new LeastStopRoute();
            var result = _cal.Calculate(origin, destination);
            if (result != null)
            {
                DrawRoutes(result, gr);
            }
        }

        public void RandomStopCal(City origin, City destination, Graphics gr)
        {
            _cal = new RandomRoute();
            var result = _cal.Calculate(origin, destination);
            if (result != null)
            {
                DrawRoutes(result, gr);
            }
        }

        public void ShortestCal(City origin, City destination, Graphics gr)
        {
            _cal = new DijkstraRoute(this);
            var result = _cal.Calculate(origin, destination);
            if (result != null)
            {
                DrawRoutes(result, gr);
            }
        }

        public void CreateAMap()
        {
            List<List<string>> all = new List<List<string>>();
            all = _file.LoadMap();
            List<string> dim = all[0];
            dimentions.X = Convert.ToInt32(dim[0]);
            dimentions.Y = Convert.ToInt32(dim[1]);
            List<string> cit = all[1];
            List<string> con = all[2];
            AddCity(cit, Cities);
            AddConnection(con, Cities);
            }

        public void AddCity(IEnumerable<string> lines, ICollection<City> cities)
        {
            foreach (string st in lines)
            {
                string[] ssizes = st.Split(' ', '\t');
                City c = new City(ssizes[0], Convert.ToInt32(ssizes[1]), Convert.ToInt32(ssizes[2]));
                cities.Add(c);
            }
        }

        private bool IsExist(City c, IEnumerable<City> cities)
        {
            return cities.Any(city => city.X == c.X && city.Y == c.Y);
        }

        public void AddConnection(IReadOnlyList<string> lines, List<City> cities)
        {
            //Find how many elements are in lines
            int j = lines.Count;
            for (int i = j - 1; i >= 2; i--)
            {
                if (lines[i - 1] == "EINDE") continue;
                string[] ssizes = lines[i - 1].Split(' ', '\t');
                City m = cities.Find(t => t.Name == ssizes[0]);
                int indexin = 0;
                foreach (string st in ssizes.Where(st => m.Name != st))
                {
                    indexin++;
                    if (!cities.Exists(t => t.Name == st)) continue;
                    City found = cities.Find(r => r.Name == ssizes[indexin]);
                    int length = Convert.ToInt32(ssizes[indexin + 1]);
                    m.Connections.Add(new Connection(found, length));
                    found.Connections.Add(new Connection(m, length));
                }
            }
        }

    }
}
