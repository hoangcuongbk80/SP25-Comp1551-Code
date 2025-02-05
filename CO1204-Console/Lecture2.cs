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

            /*Console.WriteLine("Logical Expression:");
            int UserInput;
            bool Flag;
            Console.WriteLine("Enter a value:");
            UserInput = Convert.ToInt32(Console.ReadLine());
            Flag = (UserInput > 0);
            Console.WriteLine("The value is positive, {0}", Flag);*/

            /*Console.WriteLine("IF ELSE example:");
            int UserInput;
            bool Flag;
            Console.WriteLine("Enter a value:");
            UserInput = Convert.ToInt32(Console.ReadLine());
            Flag = (UserInput > 0);

            if(UserInput > 0)
            {
                Console.WriteLine("The value is positive");
            }
            else
            {
                Console.WriteLine("The value is negative");
            }*/

            /*int i, j;
            for(i = 1; i < 10; i++)
            {
                for (j = 1; j < 10; j++)
                {
                    int r = i * j;
                    Console.Write("{0} ", r);
                }
                Console.WriteLine("\n");
            }
                
            Console.Read();*/

            int a = 10;
            int[] myNumber = { 10, 20, 30 };
            Console.WriteLine("The first element of the array: {0}", myNumber[0]);

            Console.Write("Array: ");
            foreach (int i in myNumber) Console.Write("{0} ", i);
            Console.WriteLine();

            Console.Write("Array: ");
            for (int i = 0; i < myNumber.Length; i++)
            {
                Console.Write("{0} ", myNumber[i]);
            }
        }
    }
}
