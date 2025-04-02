using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO1204_Console
{
    public enum EmployeeRole {
        Manager,
        Developer,
        QAEngineer
    }
    public class Employee{
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public EmployeeRole Role { get; set; }
        public void DisplayEmployeeDetails(){
            Console.WriteLine("Employee ID: {0}", EmployeeID);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Role : {0}", Role);
        }
    }
    internal class Lecture5_Enum{
        static void Main1(string[] args){
            Employee manager = new Employee{EmployeeID = 1, Name = "John Manager", Role = EmployeeRole.Manager};
            Employee developer = new Employee{EmployeeID = 2, Name = "Alice Developer", Role = EmployeeRole.Developer};
            Employee qaEngineer = new Employee{EmployeeID = 3, Name = "Bob QA Engineer", Role = EmployeeRole.QAEngineer};

            Console.WriteLine("Employee Details:");
            manager.DisplayEmployeeDetails();
            developer.DisplayEmployeeDetails();
            qaEngineer.DisplayEmployeeDetails();

        }
    }
}
