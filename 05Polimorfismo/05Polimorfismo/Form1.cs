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
    }
}
