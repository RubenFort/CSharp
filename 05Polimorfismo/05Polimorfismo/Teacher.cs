using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Polimorfismo
{
    class Teacher:Employee
    {
        public string employeePosition { get; set; }

        public string getValues()
        {
            string text = "Employee ID: " + employeeId + Environment.NewLine;
            text += "Employee Name: " + name + Environment.NewLine;
            text += "Employee Salary: " + employeeSalari + Environment.NewLine;
            text += "Employee Position: " + employeePosition + Environment.NewLine;
            return text;
        }
    }
}
