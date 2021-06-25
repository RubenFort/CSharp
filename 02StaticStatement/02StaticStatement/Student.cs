using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02StaticStatement
{
    class Student
    {
        public static int studentNumber { get; set; }
        public static void getAddNote()
        {
            MessageBox.Show("Static");
        }
    }
}
