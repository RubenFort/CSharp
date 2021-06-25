using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07PartialClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public partial class Employee
        {
            public int employeeId { get; set; }
            public string name { get; set; }
            public double salary { get; set; }
        }

        public partial class Employee
        {
            public void setValues()
            {
                name = "Charles";
                employeeId = 1;
                salary = 2000;
            }
        }
    }
}
