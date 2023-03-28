using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101,"Pratik","Developer");
            Employee.CompanyName = "Mastek";

            Console.WriteLine(e1.EmpId+" "+e1.EmpName+" "+e1.Role+" "+Employee.CompanyName);

            //e1.Salary = 1000;         connot assign its read only
            //e1.Tax = 10;

        }
    }

    public class Employee
    {
        private int _empId;
        private string _empName;
        private string _role;
        private double _salary;
        private double _tax;

        private static string _companyName;

        // Property : it is a collection of 2 accessor(get,set)
        //            its goal is to receive value, validate it and then assign it to variable.
        //            its like security layer aroun field.
        //            access modifier is applicable for the property, set accessor and get accessor individually.
        //            But access modifier of accessors must be more restrictive than access modifier of property.

        public int EmpId
        {
            set { _empId = value; }
            get { return _empId; }
        }

        public string EmpName
        {
            set { _empName = value; }
            get { return _empName; }
        }

        public string Role
        {
            set { _role = value; }
            get { return _role; }
        }

        public static string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        // Read-Only Property :  Proerty with only get accessor.
        public double Salary
        {
            get { return _salary; }
        }

        // Write-Only Property : Property with only set accessor.
        public double Tax
        {
            set { _tax = value; }
        }

        public Employee(int empid, string name, string role)
        {
            _empId = empid;
            _empName = name;
            _role = role;   
        }

        public void Print()
        {
            Console.WriteLine(_empId+" "+_empName+" "+_role+" "+_companyName);
        }
    }

    public class Employee2
    {
        // Automatic properties.
        // Here compiler will automatically create private fields (i.e private int _empId)
        public int EmpId { set; get; }
        public string EmpName { set; get; }
        public string Role { set; get; }
        public double Salary { get; }
        public double Tax { set; get; }

        public static string CompanyName { set; get; }

        // You can initialise auto-implemented property.
        public string NativePlace { set; get; } = "Phaltan";

        public Employee2(int empid, string name, string role)
        {
            EmpId = empid;
            EmpName = name;
            Role = role;
        }

        public void Print()
        {
            Console.WriteLine(EmpId + " " + EmpName + " " + Role + " " + CompanyName);
        }
    }
}
