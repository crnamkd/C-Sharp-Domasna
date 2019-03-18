using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyClasses
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }

        public Employee(string name, string lastName, double salary)
        {
            FirstName = name;
            LastName = lastName;
            Salary = salary;
        }
        

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} gets : {Salary} monthly salary !");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
        
    }
    
}
