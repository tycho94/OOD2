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
        private Algorithm algorithmChoice;

        public Form1()
        {
            InitializeComponent();
        }


        public void ClearMap();

        public void RefreshMap();

        

    }
}
