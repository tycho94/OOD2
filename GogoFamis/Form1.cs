using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GogoFamis
{
    public partial class Form1 : Form
    {

        private Point routeStartPoint;
        private Point routeEndPoint;
        private Route algorithmChoice;
        private static Point size;
        private static FileHelper loader;
        private Map map;

        public Form1()
        {
            loader = new FileHelper("resources/nederland.txt");
            map = new Map(loader.LoadLocation(out size));
            map = new Map(loader.LoadLocation(out size), loader.LoadConnection(map.LocationList));

            InitializeComponent();

        }


        //public void ClearMap();

        //public void RefreshMap();

        

    }
}
