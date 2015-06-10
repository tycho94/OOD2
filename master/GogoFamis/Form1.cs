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
        /// <summary>
        /// the x and y of this point will be furthest location, this way we can know how big to make the form map.
        /// </summary>
        private static Point size;
        private static FileHelper loader;
        private Map map;

        public Form1()
        {
            loader = new FileHelper("../../resources/nederland.txt");
            map = new Map(loader.LoadLocation(out size));
            map = new Map(loader.LoadLocation(out size), loader.LoadConnection(map.LocationList));
            Console.WriteLine(map.LocationList[(map.LocationList.Count)-1].Name);
            Console.WriteLine(map.LocationList[(map.LocationList.Count) - 2].Name);
            InitializeComponent();
        }


        //public void ClearMap();

        //public void RefreshMap();



    }
}
