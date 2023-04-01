using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Manager : Employee
    {
        public string DepartmentName { get; set; }

        public Manager()
        {
            DepartmentName = "Anonymous";
        }

        public Manager(string dname)
        {
            DepartmentName = dname;
        }

        public int GetSalesValueOfYear()
        {
            return 1000;
        }

        public void GetFullDepartmentName()
        {
            Console.WriteLine(DepartmentName+" "+base.Location);
        }

        public new void GetHealthInssuranceAmount()     // method hiding can be done without "new" keyword, but it is only used to indicate to compiler and user about method hiding
        {
            Console.WriteLine(700);
        }

        public void GetManagerDetails()
        {
            Console.WriteLine(EmpId + " " + EmpName + " " + Location + " " + DepartmentName);
        }
    }
}
