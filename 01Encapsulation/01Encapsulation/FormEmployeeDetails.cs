using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Encapsulation
{
    public partial class FormEmployeeDetails : Form
    {
        public FormEmployeeDetails()
        {
            InitializeComponent();
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            //Cierra el formulario
            this.Close();
        }
    }
}
