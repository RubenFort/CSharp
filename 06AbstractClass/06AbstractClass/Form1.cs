using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06AbstractClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class Vehicle
        {
            public abstract double getFuel();
        }

        class Bus : Vehicle
        {
            public override double getFuel()
            {
                return 300;
            }
        }

        class Truck : Vehicle
        {
            public override double getFuel()
            {
                return 500;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string text = "";
            Vehicle vc;
            vc = new Bus();
            double busFuel = vc.getFuel();
            text += "Bus Fuel Amount is: " + busFuel.ToString() + Environment.NewLine;
            vc = new Truck();
            double truckFuel = vc.getFuel();
            text += "Truck Fuel Amount is: " + busFuel.ToString() + Environment.NewLine;
            textBoxShow.Text = text;
        }
    }
}
