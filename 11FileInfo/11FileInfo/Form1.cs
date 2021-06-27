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

namespace _11FileInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //File.Create("FisrtFile.txt");
            if (!File.Exists("FisrtFile.txt"))
            {
                FileInfo ourFile = new FileInfo("FisrtFile.txt");
                ourFile.Create();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists("FisrtFile.txt"))
            {
                File.Delete("FisrtFile.txt");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.OpenOrCreate, FileAccess.Write);   //(Path, controlar si existe o no el fichero
                                                                                                    //y crear un en su lugar, acceso a la escritura o lectura)
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This is first lines");
            sw.WriteLine("This is second lines");
            sw.WriteLine("This is third lines");
            sw.Flush();//Transferir datos desdxed el flujo temporal al fichero
            sw.Close();
            fs.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text = "";
            while (!sr.EndOfStream)
            {
                text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
            fs.Close();
            txtRead.Text = text;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            File.Copy("third.txt", @"C:\Users\Crowley\source\repos\Udemy - Programación Orientada a Objetos en C#\11FileInfo\11FileInfo\third.txt");
        }
    }
}
