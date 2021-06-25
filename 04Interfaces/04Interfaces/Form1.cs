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

        interface DellComputer
        {
            void getMark();
        }

        class DellComputers : Computer,DellComputer
        {
            public string name { get; set; }
            public double price { get; set; }
            public string mark { get; set; }

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

            public void getMark()
            {
                mark = "Dell";
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            DellComputers dell = new DellComputers();
            dell.getLaptops();
            dell.getMark();
            string textValue = "Name: " + dell.name + Environment.NewLine;
            textValue += "Price: " + dell.price + Environment.NewLine;
            textValue += "Mark: " + dell.mark;
            textBox1.Text = textValue;
        }
    }
}
