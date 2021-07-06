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

        class HoldFileLogs
        {
            public string Message { get; set; }
            public void LogContext()
            {

            }
        }

        class HoldDBLogs
        {
            public string Message { get; set; }
            public void LogContext()
            {
         
            }
        }

        class ManageLogs
        {
            private HoldFileLogs holdFileLogs;
            private HoldDBLogs holdDBLogs;
            public ManageLogs()
            {
                holdFileLogs = new HoldFileLogs();
                holdDBLogs = new HoldDBLogs();
            }

            public void LogContext()
            {
                holdFileLogs.LogContext();
                holdDBLogs.LogContext();
            }
        }
    }
}
