using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14DependencyInversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface Ilogger
        {
            string Message { get; set; }
            void LogContext();
        }

        class HoldFileLogs : Ilogger
        {
            public string Message { get; set; }
            public void LogContext()
            {

            }
        }

        class HoldDBLogs : Ilogger
        {
            public string Message { get; set; }
            public void LogContext()
            {
         
            }
        }

        //Solo dependo de la interface. La variable que nos llega a traves de los métodos nos da igual que sea 
        //tipo HoldFileLogs o HoldDBLogs, ya le llegará al constructor
        class ManageLogs
        {
            private Ilogger iloger;

            public ManageLogs(Ilogger loger)
            {
                iloger = loger;
            }

            public void LogContext(Ilogger iloger)
            {
                iloger.LogContext();
            }
        }
    }
}
