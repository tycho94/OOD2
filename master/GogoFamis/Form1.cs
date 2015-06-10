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
            InitializeComponent();
            loader = new FileHelper("../../resources/nederland.txt");
            map = new Map(loader.LoadLocation(out size));
            map = new Map(loader.LoadLocation(out size), loader.LoadConnection(map.LocationList));
            pbMap.Size = (Size)size;
            foreach (Location l in map.LocationList)
            {
                cbStart.Items.Add(l.Name);
                cbDest.Items.Add(l.Name);
            }
        }

        private void pbMap_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics, map.LocationList, map.ConnectionList);
        }

        private void Draw(Graphics gr, List<Location> loclist, List<Connection> conlist)
        {
            foreach (Location l in loclist)
            {
                gr.DrawEllipse(new Pen(Color.Red, 2f), l.Coordinates.X - 5, l.Coordinates.Y - 5, 10, 10);
                gr.DrawString(l.Name, new Font("Arial", 6), Brushes.Black, new Point(l.Coordinates.X + 5, l.Coordinates.Y));
            }
            foreach (Connection c in conlist)
            {
                gr.DrawLine(new Pen(Brushes.Black), c.Loc1.Coordinates, c.Loc2.Coordinates);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //public void ClearMap();

        //public void RefreshMap();

        private void pbMap_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoor.Text = e.X.ToString() + ", " + e.Y.ToString();
        }

        private void pbMap_Click(object sender, EventArgs e)
        {

        }






    }
}
