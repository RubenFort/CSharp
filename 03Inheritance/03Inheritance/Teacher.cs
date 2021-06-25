using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Inheritance
{
    class Teacher:Employee
    {
        public string branch { get; set; }

        public void findSalary()
            {
                salary = 2000;
            }

        public void setValues2()
        {
            position = "Teacher";
            branch = "Match";
        }
    }
}
