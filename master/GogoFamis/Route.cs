using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GogoFamis 
{
    class Route
    {
        public List<Location> Stations { get; set; }

        public Route()
        {
            Stations = new List<Location>();
        }

    }
}
