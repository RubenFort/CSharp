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
    }
}
