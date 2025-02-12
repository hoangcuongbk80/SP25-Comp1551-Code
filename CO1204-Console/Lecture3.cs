using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO1204_Console
{
    class Myclass
    {
        public Myclass() 
        {
            Console.WriteLine("Nothing");
        }
        public Myclass(int i)
        {
            Console.WriteLine("Int: {0}", i);
        }
        public Myclass(double i)
        {
            Console.WriteLine("DOuble: {0}", i);
        }
        public Myclass(string s)
        {
            Console.WriteLine("string: {0}", s);
        }

    }
    internal class Lecture3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Lecture3------------");
            Myclass MyObject = new Myclass(5.0);

            Console.Read();
        }
    }
}
