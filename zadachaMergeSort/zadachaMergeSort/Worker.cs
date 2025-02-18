using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachaMergeSort
{
    internal class Worker
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Worker(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
