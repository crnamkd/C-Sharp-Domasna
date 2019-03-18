using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyClasses
{
    public class Sales : Employee
    {
        public int SuccessSaleRevenue { get; set; }


        public Sales(string first, string last, int success)
        {
            FirstName = first;
            LastName = last;
            SuccessSaleRevenue = success;
            Salary = 500;
            RoleEmployee = Role.Sales;
        }


        public void ExtendSuccessSaleRevenue(int SuccessValue)

        {
            SuccessSaleRevenue += SuccessValue;

        }

        public override double GetSalary()
        {
            if (Salary <= 2000)
            {
                return Salary + 500;
            }
            else if (Salary >= 2000 && Salary <= 500)
            {
                return Salary + 1000;
            }
            else if (Salary >= 5000)
            {
                return Salary + 500;
            }
            else
            {
                return Salary;
            }
            
        }
        
    }
}
