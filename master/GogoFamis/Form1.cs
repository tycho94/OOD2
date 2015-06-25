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
        private Brush brush;
        int caseSwitch = 0;

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
            Graphics gr = e.Graphics;
            if (loader == null) { return; }
            else
            {
                map.DrawCity(gr, map.LocationList, brush);
                map.DrawCon(gr, map.ConnectionList);

                switch (caseSwitch)
                {
                    case 1:
                        {
                            if (cbStart.SelectedItem != null)
                                DrawSelectedLocation(routeStartPoint, e);
                            if (cbDest.SelectedItem != null)
                                DrawSelectedLocation(routeEndPoint, e);

                            break;
                        }
                    case 2:
                        {
                            map.ShortestCal(routeStartPoint, routeEndPoint, gr);
                            break;
                        }
                }
            }
        }

        //not working not sure how to implement this part 
        //for changing city and having the colored connection
        private void DrawSelectedLocation(Location l, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            brush = new SolidBrush(Color.Blue);
            gr.FillEllipse(brush, l.Coordinates.X - 5, l.Coordinates.Y - 5, 10, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbAlgorithm.Text == "Dijkstra")
            {
                caseSwitch = 2;
            }
            pbMap.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pbMap_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoor.Text = e.X.ToString() + ", " + e.Y.ToString();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "txt files (*.txt)|*.txt";
            caseSwitch = 0;
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
                    pbMap.Invalidate();
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
                caseSwitch = 1;
                pbMap.Invalidate();
            }
        }

        private void cbDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Location l in map.LocationList)
            {
                if (l.Name == cbDest.Text)
                    routeEndPoint = l;
                caseSwitch = 1;
                pbMap.Invalidate();
            }
        }
    }
}
