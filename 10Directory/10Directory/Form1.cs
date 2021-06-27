using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _10Directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("temp");//Por defecto crea la carpeta en la ruta /bin/debug
            Directory.CreateDirectory("temp1");
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Crowley\source\repos\Udemy - Programación Orientada a Objetos en C#\10Directory\10Directory\bin\Debug\temp2");
            directory.Create();

            MessageBox.Show("Folder was created");
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Move("temp", @"C:\Users\Crowley\source\repos\Udemy - Programación Orientada a Objetos en C#\10Directory\10Directory\bin\Debug\temp1\temp");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
