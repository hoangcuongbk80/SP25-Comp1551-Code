using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO1204_Console
{
    internal class Lecture1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("--------- Lecture 1 -----------");

            Console.WriteLine("Enter a Campus: ");
            string campus = Console.ReadLine();

            Console.WriteLine("Enter a year: ");
            string year_str = Console.ReadLine();
            int year = int.Parse(year_str);

            Console.WriteLine("Hi {0} students", campus);
            Console.Write("Happy ");
            Console.Write("New Year {0}!", year);

            Console.Read();
        }
    }
}
