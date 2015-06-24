using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GogoFamis
{
    abstract class Calculation
    {
        public abstract Route ResultRoute { get; set; }
        public abstract Route Calculate(Location origin, Location destination);
    }
}
