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

        //Las clases selladas no se pueden heredear
        public sealed class sealedClass
        {

        }

        //Comento la clase pq da error de compilación, no puede heredar la clase sealedClass pq es sellada
        /*public class newClass : sealedClass
        {

        }*/

        private void btnShow_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.setValues();
            textBoxShow.Text = emp.employeeId + Environment.NewLine;
            textBoxShow.Text += emp.name + Environment.NewLine;
            textBoxShow.Text += emp.salary + Environment.NewLine;
        }
    }
}
