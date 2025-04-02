using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO1204_Console
{
    class Person
    {
        private string FirstName = "";
        private string LastName = "";
        public string getFirstName()
        {
            return FirstName;
        }
        public string getLastName() { 
            return LastName;
        }
        public void setFirstName(string FN)
        {
            FirstName = FN;
        }
        public void setLastName(string LN)
        {
            LastName = LN;
        }

    }
    internal class Lecture5_ArrayObject
    {
        public static void Main()
        {
            Console.WriteLine("---------------Array of Objects-------------");
            int i;
            Person[] People = new Person[10];
            for(i = 0; i < People.Length; i++)
            {
                People[i] = new Person();
            }
            People[0].setFirstName("Cuong");
            People[0].setLastName("Hoang");
            People[1].setFirstName("Nam");
            People[1].setLastName("Nguyen");

            i = 1;
            foreach(Person a in People)
            {
                Console.WriteLine("{0} {1} {2}", i, a.getFirstName(), a.getLastName());
                i++;
            }

            Console.WriteLine("---------------List of Objects-------------");

            List<Person> MyList = new List<Person>();
            MyList.Add(People[0]);
            MyList.Add(People[1]);
            i = 1;
            foreach (Person a in MyList)
            {
                Console.WriteLine("{0} {1} {2}", i, a.getFirstName(), a.getLastName());
                i++;
            }
        }
    }
}
