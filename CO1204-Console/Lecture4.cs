using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO1204_Console4
{
    public class BankAccount
    {
        public string AccountHolder { get; private set; }
        private double balance;
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value >= 0) 
                    balance = value;
                else
                    Console.WriteLine("Balance cannot be negative!");
            }
        }
        public BankAccount(string name, double initialBalance)
        {
            AccountHolder = name;
            Balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive!");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount}. Remaining Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid withdrawal amount!");
            }
        }
    }

    class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;
        private double D;
        public double? x1;
        public double? x2;

        public void Calculate(double p1, double p2, double p3)
        {
            a = p1; b = p2; c = p3;
            D = Convert.ToDouble(b * b - 4 * a * c);
            if ((a != 0) && (D >= 0))
            {
                x1 = Convert.ToDouble((-b + Math.Sqrt(D)) / (2 * a));
                x2 = Convert.ToDouble((-b - Math.Sqrt(D)) / (2 * a));
            }
            else
            {
                x1 = null; x2 = null;
            }
        }
    }

    class Student
    {
        public void doCourseWork(int p)
        {
            Console.WriteLine("Group {0} people", p);
        }
        public void doCourseWork(string AI)
        {
            Console.WriteLine("{0} help", AI);
        }
    }
    class Lecture4
    {
        static void Main1(string[] args)
        {
            Student s = new Student();
            s.doCourseWork(3);
            s.doCourseWork("ChatGPT");


            /*Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            QuadraticEquation myEq = new QuadraticEquation();
            myEq.Calculate(a, b, c);
            Console.WriteLine("x1={0}, x2={1}", myEq.x1, myEq.x2);
*/

            /*BankAccount myAccount = new BankAccount("John Doe", 500);
            Console.WriteLine($"Account Holder: {myAccount.AccountHolder}");
            Console.WriteLine($"Initial Balance: {myAccount.Balance}");
            myAccount.Deposit(200);
            myAccount.Withdraw(100);
            myAccount.Withdraw(700);*/

            Console.Read();
        }
    }
}
