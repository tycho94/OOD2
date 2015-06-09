using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMapProject
{
    public class Route
    {
        public List<City> Stations { get; set; }

        public Route()
        {
            Stations = new List<City>();
        }

    }
}
