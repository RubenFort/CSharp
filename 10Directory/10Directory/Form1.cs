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
            //Comrpobamos si existe el directorio folder2, si no existe lo creamos
            if (!Directory.Exists("folder2"))
            {
                Directory.CreateDirectory("folder2");
            }

            Directory.CreateDirectory("temp");//Por defecto crea la carpeta en la ruta /bin/debug
            Directory.CreateDirectory("temp1");
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Crowley\source\repos\Udemy - Programación Orientada a Objetos en C#\10Directory\10Directory\bin\Debug\temp2");
            Directory.CreateDirectory("temp3");
            directory.Create();
            MessageBox.Show("Folder was created");

            string accessTime = directory.LastAccessTime.ToString();
            string createTime = directory.CreationTime.ToString();
            MessageBox.Show("Ultimo acceso: " + accessTime + Environment.NewLine + "Fecha de creación: " + createTime);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Move("temp", @"C:\Users\Crowley\source\repos\Udemy - Programación Orientada a Objetos en C#\10Directory\10Directory\bin\Debug\temp1\temp");
                MessageBox.Show("Folder was moved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete("temp3");
                MessageBox.Show("Folder was deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
