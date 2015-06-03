using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GogoFamis
{
    class FileHelper
    {
        private string location;

        public FileHelper(string location) { this.location = location; }

        public List<Location> LoadLocation();

        public List<Connection> LoadConnection();

        private void CheckLocationOverlap();

    }
}
