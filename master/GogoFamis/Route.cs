using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GogoFamis
{
    abstract class Route
    {
        public abstract List<Location> CalculateNext();
    }
}
