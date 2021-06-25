using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Polimorfismo
{
    public class Employee2
    {
        public int employeeId { get; set; }
        public string name { get; set; }
        public double employeeSalari { get; set; }
        public string employeePosition { get; set; }

        public virtual string setValues(int id, string employeeName, double salary)
        {
            employeeId = id;
            name = employeeName;
            employeeSalari = salary;

            string text = "Employee ID: " + employeeId + Environment.NewLine;
            text += "Employee Name: " + name + Environment.NewLine;
            text += "Employee Salary: " + employeeSalari + Environment.NewLine;
            return text;
        }
    }
}
