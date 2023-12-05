using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2._19_Class_Methods
{
    internal class Student
    {
        public double weight;
        public string name;
        public int age;

        public Student(double aWeight, string aName, int aAge)
        {

            this.weight = aWeight; 
            this.name = aName;
            this.age = aAge;
        }

        public bool IsObese()
        {
            if (weight > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
