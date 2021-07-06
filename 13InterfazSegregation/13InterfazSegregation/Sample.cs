using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13InterfazSegregation
{
    interface Base
    {
        string Name { get; set; }
        string ProductMark { get; set; }
        double Salary { get; set; }
    }

    interface Food
    {
        double Calori { get; set; }
    }

    interface Clothes
    {
        int Size { get; set; }
    }

    class Meal : Base, Food
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProductMark { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Calori { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Trousers : Base, Clothes
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProductMark { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
