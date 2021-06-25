using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Polimorfismo
{
    public class Employee
    {
        public int employeeId { get; set; }
        public string name { get; set; }
        public double employeeSalari { get; set; }

        public void setValues (int id)
        {
            employeeId = id;
        }
    }
}
