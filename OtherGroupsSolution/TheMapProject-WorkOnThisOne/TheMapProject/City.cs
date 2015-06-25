using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace TheMapProject
{
    public class City
    {
        public readonly string Name;
        public readonly int X;
        public readonly int Y;
        public readonly List<Connection> Connections;

        public City(string name, int x, int y)
        {
            Name = name;
            
            Connections = new List<Connection>();
        }

        public override string ToString()
        {
            string s = "Name: " + Name + " x " + X + " y: " + Y + " connections :";

            return Connections.Aggregate(s, (current, c) => current + c.ToString());
        }
        public List<Connection> GetConnections()
        {
           return Connections;
        }
    }
}
