using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.EmpId = 101;
            emp1.EmpName = "Chinmay";
            emp1.Location = "Mumbai";

            Manager manager = new Manager();
            manager.EmpId = 102;
            manager.EmpName = "Pratik";
            manager.Location = "Kamothe";
            manager.DepartmentName = "Accounts";
            Console.WriteLine(manager.GetSalesValueOfYear());

            Salesman salesman = new Salesman();
            salesman.EmpId = 103;
            salesman.EmpName = "Prasad";
            salesman.Location = "Kalyan";
            salesman.Region = "Rambaug";
            Console.WriteLine(salesman.GetSalesOfTheCurrentMonth());


            // Types of inheritance
            // Single, Multi-level, Hierachical, Multiple, Hybrid.
            // Hybrid Inheritance : Hierarchical + Multi-level
            // Note : Multiple inheritance is not possible.


            // base : it is keyword by default available in child class to access the members(fields, method, properties, constructors) of parent class.
            //  its optional to use by default, should use in case of name ambiguity.

            manager.GetFullDepartmentName();


            // Calling Parent class Constructor from Child class:
            //      It is optional to call parent class "PARAMETER-LESS cosntructor" from child class
            //      because when object of child class is creatd, parameterless constructor of parent class is called automatically.

            //      It is MUST to call parent class parameterized constructor from child class and pass necessary argument.

            Manager manager1 = new Manager("HR");
            manager1.GetManagerDetails();

            Salesman salesman1 = new Salesman(104,"Shivam","Kanjur","nagar");
            salesman1.GetSalesManDetails();


            // Method Hiding : it is concept which is used to hide(overwrite) the parent class method, by creating another
            //                 method in child class with SAME NAME & SAME PARAMETERS.


            // Syntax : public return_type Parent_Method_Name()
            //          {
            //              // code
            //          }

            //          public new return_type Child_Method_Name()
            //          {
            //              // code
            //          }

            Console.WriteLine("Start Method Hiding");

            Employee employee3 = new Employee();
            employee3.GetHealthInssuranceAmount();

            Manager manager2 = new Manager();
            manager2.GetHealthInssuranceAmount();

            Employee employee4 = new Manager();
            employee4.GetHealthInssuranceAmount();

            Console.WriteLine("End Method Hiding");


            // Method overiding : it is concept which is used to EXTEND the parent class method, by creating another
            //                    method in child class with SAME NAME & SAME PARAMETERS.
            //                    "virtual" keyword is used for parent class method.
            //                    "override" keyword is used for base class method.


            // Syntax : public virtual return_type Parent_Method_Name()
            //          {
            //              // code
            //          }

            //          public override return_type Child_Method_Name()
            //          {
            //              base.Parent_Method_Name();
            //              // code
            //          }

            //                      its not compulsory to override all virtual method in childe class.

            Employee employee5 = new Manager();
            employee5.GetLifeInssuranceAmount();

            Salesman salesman2 = new Salesman();
            salesman2.GetLifeInssuranceAmount();

            Employee employee6 = new Salesman();
            employee6.GetLifeInssuranceAmount();


            // Sealed Class : it is class which CANNOT be inherited.
            //                sealed class Class1 { }
            //                Class 2 : Class1 { }          // NOT POSSIBLE
            //                can inherit from other class or interface.
            //                you cannot create abstract or virtual methods in sealed class.
            //                it is concept used for security purpose.


            // Sealed Methods : it must be "override methods" which can`t be overriden in child class.

            Console.ReadKey();
        }
    }
}
