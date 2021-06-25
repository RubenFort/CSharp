using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Polimorfismo
{
    public class Teacher2:Employee2
    {
        override public string setValues(int id, string employeeName, double salary)
        {
            employeeId = id;
            name = employeeName;
            employeeSalari = salary;
            employeePosition = "Teacher";

            string text = "Employee ID: " + employeeId + Environment.NewLine;
            text += "Employee Name: " + name + Environment.NewLine;
            text += "Employee Salary: " + employeeSalari + Environment.NewLine;
            text += "Employee Position: " + employeePosition + Environment.NewLine;
            return text;
        }
    }
}
