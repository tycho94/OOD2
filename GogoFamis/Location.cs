﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GogoFamis
{
    class Location
    {


        public string Name;
        public Point Coordinates;




        public Location(string name, Point Coord)
        {
            this.Name = name;
            this.Coordinates = Coord;
        }

    }
}