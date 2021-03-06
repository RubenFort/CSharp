using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.setValues(1);
            string messageText = teacher.getValues();
            textBox1.Text = messageText;
        }

        private void btn2Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.setValues(1, "Charles");
            string messageText = teacher.getValues();
            textBox1.Text = messageText;
        }

        private void btn3Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.setValues(1, "Charles", 1856);
            string messageText = teacher.getValues();
            textBox1.Text = messageText;
        }

        private void btn4Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.setValues(1, "Charles", 1856, "Enginee");
            string messageText = teacher.getValues();
            textBox1.Text = messageText;
        }

        private void btnVirtual_Click(object sender, EventArgs e)
        {
            Employee2 emp2 = new Employee2();
            string messageText = emp2.setValues(1, "Charles", 1856);
            textBox1.Text = messageText;
        }

        private void btnOverride_Click(object sender, EventArgs e)
        {
            Teacher2 teacher2 = new Teacher2();
            string messageText = teacher2.setValues(1, "Charles", 1856);
            textBox1.Text = messageText;
        }
    }
}
