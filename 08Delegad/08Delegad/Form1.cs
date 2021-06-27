using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08Delegad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void fillTextBox(int x);
        string textValues = "";

        public void fillLanguageNote(int ExamNote)
        {
            textValues += "Language note: " + ExamNote + Environment.NewLine;
        }

        public void fillMathNote(int ExamNote)
        {
            textValues += "Math note: " + ExamNote + Environment.NewLine;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            fillTextBox fillText = new fillTextBox(fillMathNote);
            fillText += fillLanguageNote; //Añado una segunda función con +,
            fillText(10);
            fillText -= fillMathNote;//Con - quito una función
            fillText(8);
            showInTextBox();
        }

        public void showInTextBox()
        {
            textBox1.Text = textValues;
        }
    }
}
