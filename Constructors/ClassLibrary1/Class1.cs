using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {
        public int empId;
        public string empName;
        public string role;
        public static int empCount;

        // all access modifiers are applicable to constructor, its private by default.
        // only static modifier is applicable to constructor.
        // its recommended tobe public or internal.
        // does not have return type.

        public Employee()
        {
            empId = 1;
            empName = "Anonymouse";
            role = "Anonymous";
            ++empCount;
        }

        // constructor overloading is possible.

        public Employee(int empId, string empName, string role)
        {
            this.role = role;
            this.empId = empId;
            this.empName = empName;
            ++empCount;
        }

        // static constructor initialises static fields.
        // static constructor executes only once i.e when 1st object is created for the class OR when class is accessed for the firts 
        //  time during the execution of main method.
        // its public by default & we can`t change its access modifier.

        static Employee()
        {
            empCount = 100;
        }

        public void Print()
        {
            Console.WriteLine(empId + " " + empName + " " + role);        
        }

        public static void TotalEmp()
        {
            Console.WriteLine(empCount);
        }
    }
}
