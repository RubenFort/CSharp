using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try //try + tab + tab => crea la estructura try{}catch(){}
            {
                int result = int.Parse(txtNum1.Text) / int.Parse(txtNum2.Text);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Usa solo números enteros");
            }
            finally
            {
                MessageBox.Show("Programa finalizado");
            }
        }
    }
}
