using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO1204_Console
{
    internal class Lecture2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Lecture 2 -----------");

            // Variable example
            /*Console.WriteLine("\nVariable example:");
            int myVariable = 5;
            int myNewVariable;
            myVariable = 10;
            myNewVariable = 20;
            Console.WriteLine("{0} {1}");*/

            // Constant example
            /*Console.WriteLine("\nConstant example: ");
            const int myConst = 5;
            Console.WriteLine($"{myConst}.");*/

            //Print values and data types
            /*int IntegerNumber = 5;
            double RealNumber = 5.5;
            char Symbol = 'A';
            string Text = "Hello";
            bool Flag = true;
            Console.WriteLine("\nValues: ");
            Console.WriteLine(IntegerNumber);
            Console.WriteLine(RealNumber);
            Console.WriteLine(Symbol);
            Console.WriteLine(Text);
            Console.WriteLine(Flag);

            Console.WriteLine("\nData Types: ");
            Console.WriteLine(IntegerNumber.GetType());
            Console.WriteLine(RealNumber.GetType());
            Console.WriteLine(Symbol.GetType());
            Console.WriteLine(Text.GetType());
            Console.WriteLine(Flag.GetType());*/

            Console.WriteLine("Logical Expression:");
            int UserInput;
            bool Flag;
            Console.WriteLine("Enter a value:");
            UserInput = Convert.ToInt32(Console.ReadLine());
            Flag = (UserInput > 0);
            Console.WriteLine("The value is positive, {0}", Flag);

            Console.Read();
        }
    }
}
