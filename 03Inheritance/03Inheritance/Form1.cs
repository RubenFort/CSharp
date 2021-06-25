using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            Teacher teacher = new Teacher();
            teacher.setValues();
            teacher.setValues2();
            teacher.findSalary();
            string allValues = "";
            allValues += teacher.name + Environment.NewLine;
            allValues += teacher.gender + Environment.NewLine;
            allValues += teacher.age + Environment.NewLine;
            allValues += teacher.branch + Environment.NewLine;
            allValues += teacher.getSalary() + Environment.NewLine;
            allValues += teacher.plus + Environment.NewLine;
            textBox1.Text = allValues;
        }
    }
}
