using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08Enumerados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum colors { red, blue, white = 5, black };

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Al parsear un enum a int, obtenemos el valor de su indice
            String text = "Red: " + (int)colors.red + Environment.NewLine;
            text += "Blue: " + (int)colors.blue + Environment.NewLine;
            text += "White: " + (int)colors.white + Environment.NewLine;
            text += "Black: " + (int)colors.black + Environment.NewLine;
            text += "**********************" + Environment.NewLine; ;

            //GetValues devuelve el valore numérico de cada enum
            foreach (int i in Enum.GetValues(typeof(colors))){
                text += i + Environment.NewLine;
            }
            text += "**********************" + Environment.NewLine; ;

            //GetNames devuelve el nombre de cada enum
            foreach (string str in Enum.GetNames(typeof(colors)))
            {
                text += str + Environment.NewLine;
            }

            textBox1.Text = text;
        }

    }
}
