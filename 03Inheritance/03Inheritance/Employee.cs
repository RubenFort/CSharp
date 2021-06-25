using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Inheritance
{
    class Employee:Human
    {
        protected string position { get; set; }
        protected double salary { get; set; }

        public void setValues()
        {
            name = "Charles";
            id = 1;
            gender = 'M';
            age = 30;
        }
    }
}
