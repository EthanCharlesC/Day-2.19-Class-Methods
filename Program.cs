using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2._19_Class_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(70, "John", 15);
            Student student2 = new Student(40, "Tim", 10);

            Console.WriteLine(student1.IsObese());
            Console.WriteLine(student2.IsObese());
            Console.ReadKey();


        }
    }
}
