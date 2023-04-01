using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp;

            Employee.TotalEmp();
            Employee emp1 = new Employee();

            Employee.TotalEmp();
            Employee emp2 = new Employee(22, "Pratik", "developer");

            Employee.TotalEmp();

            emp1.Print();
            emp2.Print();


            // Object Initializer : Special syntax to initialize fields / properties of clas, along with creating the object.
            //                      Executes after constructor.
            //                      Its only for initialization fields / properties after object creation
            //                      You can intialize desired fields that you want.

            Employee emp3 = new Employee() { empName = "Mohite", role = "Developer" };
            emp3.Print();

        }
    }
}
