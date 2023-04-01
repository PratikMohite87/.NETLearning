using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {
        public int EmpId { set; get; }
        public string EmpName { set; get; }
        public string Location { set; get; }

        public Employee()
        {
            EmpId = 0;
            EmpName = "Anonymous";
            Location = "Anonymous";
        }

        public Employee(int empId, string name, string location)
        {
            EmpId = empId;
            EmpName = name;
            Location = location;
        }

        public void GetHealthInssuranceAmount()
        {
            Console.WriteLine(500);
        }

        public virtual void GetLifeInssuranceAmount()
        {
            Console.WriteLine(1000);
        }

        public void GetEmployeeDetails()
        {
            Console.WriteLine(EmpId+" "+EmpName+" "+Location);
        }

    }
}
