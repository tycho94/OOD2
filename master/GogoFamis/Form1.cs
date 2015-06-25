using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GogoFamis
{
    public partial class Form1 : Form
    {
        private Location routeStartPoint;
        private Location routeEndPoint;
        private Route algorithmChoice;
        private Brush brush;
        private Pen pen;
        

        /// <summary>
        /// the x and y of this point will be furthest location, this way we can know how big to make the form map.
        /// </summary>
        private static Point size;
        private static FileHelper loader;
        private Map map;


        public Form1()
        {
            InitializeComponent();
        }

        private void pbMap_Paint(object sender, PaintEventArgs e)
        {
            brush = new SolidBrush(Color.Red);
            if (loader == null) { return; }
            else
                DrawCity(e.Graphics, map.LocationList,brush);
                DrawCon(e.Graphics, map.ConnectionList);
        }

        private void DrawCity(Graphics gr, List<Location> loclist, Brush brush)
        {
           
            foreach (Location l in loclist)
            {
                
                gr.FillEllipse(brush, l.Coordinates.X-5, l.Coordinates.Y-5, 10,10);
                gr.DrawString(l.Name, new Font("Arial", 6), Brushes.Black, new Point(l.Coordinates.X + 5, l.Coordinates.Y));
            }
            

        }

        private void DrawCon(Graphics gr, List<Connection> conlist)
        {
            foreach (Connection c in conlist)
            {
                gr.DrawLine(new Pen(Brushes.Black), c.Loc1.Coordinates, c.Loc2.Coordinates);
            }
        
        }


        //not working not sure how to implement this part 
        //for changing city and having the colored connection
        private void DrawStartDest(Route route, Graphics gr, PaintEventArgs e)
        {
           
            brush = new SolidBrush(Color.Blue);
            DrawCity(e.Graphics, map.LocationList,brush);
            DrawCon(e.Graphics,map.ConnectionList);

            for (int i = 0; i < route.Cities.Count - 1; i++)
            {
                gr.DrawLine(pen, route.Cities[i].Coordinates.X, route.Cities[i].Coordinates.Y,route.Cities[i + 1].Coordinates.X, route.Cities[i + 1].Coordinates.Y); 
            }

            brush = new SolidBrush(Color.Blue);
            DrawCity(gr,route.Cities[0],brush);

            brush = new SolidBrush(Color.Green);
            //Draw(gr, route.Stations[route.Stations.Count-1]);

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

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Stream stream;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "txt files (*.txt)|*.txt";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openDialog.OpenFile()) != null)
                {
                    string fn = openDialog.FileName;


                    loader = new FileHelper(fn);
                    map = new Map(loader.LoadLocation(out size));
                    map = new Map(loader.LoadLocation(out size), loader.LoadConnection(map.LocationList));
                    pbMap.Size = (Size)size;
                    foreach (Location l in map.LocationList)
                    {
                        cbStart.Items.Add(l.Name);
                        cbDest.Items.Add(l.Name);
                    }
                    pbMap.Refresh();

                }
            }
            else
            {
                MessageBox.Show("No file has been loaded");
            }
        }



        private void cbStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Location l in map.LocationList)
            {
                if (l.Name == cbStart.Text)
                    routeStartPoint = l;
                 brush = new SolidBrush(Color.Blue);
         
               
                
            }            
        }

        private void cbDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Location l in map.LocationList)
            {
                if (l.Name == cbDest.Text)
                    routeEndPoint = l;
            }            
        }
    }
}
