using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface Computer
        {
            void getDesktops();
            void getLaptops();
        }

        class DellComputer : Computer
        {
            public string name { get; set; }
            public double price { get; set; }

            public void getDesktops()
            {
                name = "Desktop01";
                price = 1500;
            }

            public void getLaptops()
            {
                name = "Laptop01";
                price = 1200;
            }
        }
    }
}
