using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO1204_Console
{
    public class BankAccount
    {
        private double? balance;  // Private variable  

        public double? Balance
        {
            get 
            {
                if (checkPass("123"))
                    return balance;
                else
                    return null;
            }
            set {
                    if (checkPass("123"))
                        balance = value;
                    else
                        Console.WriteLine("Incorrect password!");
                }
        }
        private bool checkPass(string password)
        {
            Console.WriteLine("Please enter your password: ");
            string str = Console.ReadLine();
            if (str == password)
                return true;
            else
                return false;
        }
    }
    internal class Lecture3
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Balance = 100;
            Console.WriteLine("Balance: {0}", account.Balance);
            Console.Read();
        }
    }
}
