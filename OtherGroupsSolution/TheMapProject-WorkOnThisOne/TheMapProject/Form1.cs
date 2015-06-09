using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TheMapProject.Properties;

namespace TheMapProject
{
    public partial class Form1 : Form
    {
        private int paintMap;
        private int currentMap;
        bool[] _city;
        Information _info;
        Map _map;
        City _origin, _destination;

        public Form1()
        {
            _city = new bool[2];
            _city[0] = false;
            _city[1] = false;
            InitializeComponent();
            AddMethod();
            paintMap = 0;
            currentMap = 0;
        }
        private void AddMethod()
        {
            method_cbx.Items.Add("Shortest Route");
            method_cbx.Items.Add("Least Stop Route");
            method_cbx.Items.Add("Random Route");
        }


        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _info = new Information();
            _info.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void origin_x_Click(object sender, EventArgs e)
        {
            _city[0] = true;
            _city[1] = false;
            origin_x.Text = Resources.Form1_destination_x_Click_X;
            destination_x.Text = "";
        }

        private void destination_x_Click(object sender, EventArgs e)
        {
            _city[1] = true;
            _city[0] = false;
            origin_x.Text = "";
            destination_x.Text = Resources.Form1_destination_x_Click_X;
        }

        private void ResizePanel(int x, int y)
        {
            Size size = new Size(x + 50, y + 50);
            panel2.Size = size;
        }
        private void nederlandToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel2.Invalidate();
            paintMap = 1;
            currentMap = 1;
            _origin = null;
            _destination = null;
            panel2.Paint += panel2_Paint;
        }
        private void welcomeToUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel2.Invalidate();
            _map = new Map("WelcomeToUs");
            _origin = null;
            _destination = null;
            paintMap = 2;
            currentMap = 2;
            panel2.Paint += panel2_Paint;

        }
        private void friendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Invalidate();
            _map = new Map("Friends");
            _origin = null;
            _destination = null;
            paintMap = 4;
            currentMap = 4;
            panel2.Paint += panel2_Paint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paintMap = 3;
            List<City> cityList = _map.Cities;
            if (cityList.Count == 0)
            {
                MessageBox.Show("Please select a map");
            }
            else if (_origin == null || _destination == null)
            {
                MessageBox.Show("Please select a city");
            }
            else if (method_cbx.Text == "                      Method")
                MessageBox.Show("Please select a method!");
            else panel2.Invalidate();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // panel2.Refresh();
            Graphics gr = e.Graphics;
            if (paintMap == 1)
            {
                _map = new Map("nederland");
                _map.CreateAMap();
                ResizePanel(_map.Dimentions.X, _map.Dimentions.Y);
                _map.DrawMap(gr);
            }
            else if (paintMap == 2)
            {
                _map = new Map("WelcomeToUs");
                _map.CreateAMap();
                ResizePanel(_map.Dimentions.X, _map.Dimentions.Y);
                _map.DrawMap(gr);
            }
            else if ( paintMap == 4)
            {
                _map = new Map("Friends");
                _map.CreateAMap();
                ResizePanel(_map.Dimentions.X, _map.Dimentions.Y);
                _map.DrawMap(gr);
            }
            else
            {
                if (method_cbx.SelectedIndex == method_cbx.FindStringExact("Least Stop Route"))
                {
                    _map.LeastStopCal(_origin, _destination, gr);
                }
                else if (method_cbx.SelectedIndex == method_cbx.FindStringExact("Random Route"))
                {
                    _map.RandomStopCal(_origin, _destination, gr);
                }
                else if (method_cbx.SelectedIndex == method_cbx.FindStringExact("Shortest Route"))
                {

                    _map.ShortestCal(_origin, _destination, gr);
                }
            }
            if (_origin == null && _destination == null) return;
            Brush myBrush = new SolidBrush(Color.Red);
            if (_origin != null)
            {
                _map.DrawCity(_origin, gr, myBrush);
            }
            if (_destination == null) return;
            myBrush = new SolidBrush(Color.GreenYellow);
            _map.DrawCity(_destination, gr, myBrush);
        }

        private int SelectionCheck()
        {
            if (_city[0] == false && _city[1] == false)
            {
                return 0;
            }
            if (_city[0] && _city[1] == false)
            {
                return 1;
            }
            return 2;
        }


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            IEnumerable<City> cities = _map.Cities;
            int ischecked = SelectionCheck();
            panel2.Invalidate();
            switch (ischecked)
            {
                case 0:
                    MessageBox.Show("Please make a choice!");
                    break;
                case 1:
                    foreach (City c in cities
                   .Where(c => e.X >= (c.X - 5) && e.X <= (c.X + 5)).Where(c => e.Y >= (c.Y - 5) && e.Y <= (c.Y + 5)))
                    {
                        _origin = c;
                        label3.Text = _origin.Name;
                    }
                    break;
                case 2:

                    foreach (City c in cities
                   .Where(c => (e.X > (c.X - 5) && e.X < (c.X + 5)) && (e.Y > (c.Y - 5) && e.Y < (c.Y + 5))))
                    {
                        _destination = c;
                        label4.Text = _destination.Name;
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_origin == null && _destination == null)
            {
                MessageBox.Show("No route to clear");
            }
            else
            {
                panel2.Invalidate();
                //  method_cbx.Text = "                      Method";
                paintMap = currentMap;
                _origin = null;
                _destination = null;
                panel2.Paint += panel2_Paint;
                MessageBox.Show("Route is cleared!");
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

   





    }
}
