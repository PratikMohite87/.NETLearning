using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimqBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Name = "Pratik", Id =1},
                new Employee(){ Name ="Chinmay", Id =2},
                new Employee(){ Name = "Shivam", Id=3},
                new Employee(){ Name = "Shivam", Id=4},
            };

            // Where -----------------------------------------------------------

            var result = employees.Where(e => e.Name == "Shivam");

            foreach(var e in result)
            {
                Console.WriteLine(e.Name);
            }

            Console.WriteLine("----------------------------------------------------------------------");

            // OrderBy / OrderByDescending ----------------------------------------------------------

            IOrderedEnumerable<Employee> result2 = employees.OrderBy(e => e.Name);
            IOrderedEnumerable<Employee> result3 = employees.OrderByDescending(e => e.Name);

            foreach (var e in result2)
            {
                Console.WriteLine(e.Name);
            }

            Console.WriteLine("----------------");

            foreach (var e in result3)
            {
                Console.WriteLine(e.Name);
            }

            Console.WriteLine("----------------------------------------------------------------------");

            // ThenBy / ThenByDescending ----------------------------------------------------------

            IOrderedEnumerable<Employee> result4 = employees.OrderBy(e => e.Name).ThenBy(e => e.Id);
            IOrderedEnumerable<Employee> result5 = employees.OrderByDescending(e => e.Name).ThenByDescending(e => e.Id);

            foreach (var e in result4)
            {
                Console.WriteLine(e.Name+" "+e.Id);
            }

            Console.WriteLine("----------------");

            foreach (var e in result5)
            {
                Console.WriteLine(e.Name + " " + e.Id);
            }

            Console.WriteLine("----------------------------------------------------------------------");

            // First / FirstOrDefault -----------------------------------------------------------------

            Employee firstEmployee = employees.First(e => e.Name == "Shivam");      // Gives teh 1st element satisfying the condition. If no element found then throws InvalidOperationException.
            Console.WriteLine(firstEmployee.Id + " " + firstEmployee.Name);

            Employee firstEmployee2 = employees.FirstOrDefault(e => e.Name == "Shivam2");        // works same as First, but when no element found it return null it does not throw exception.
            //Console.WriteLine(firstEmployee2.Id + " " + firstEmployee2.Name);       // but error will come at this line because we are acessing null properties.
            if (firstEmployee2 != null)
                Console.WriteLine(firstEmployee2.Id + " " + firstEmployee2.Name);
            else
                Console.WriteLine("No employee");

            Console.WriteLine("----------------------------------------------------------------------");

            // Last / LastOrDefault----------------------------------------------------------------------

            // Works same as First / FirstOrDefault, it only gives last element matching condition.

            // ElementAt / ElementAtOrDefault -----------------------------------------------------------

            Employee employeeAt = employees.ElementAt(0);        //gives data at specified index, if not found them throws error.
            Console.WriteLine(employeeAt.Id + " " + employeeAt.Name);

            Employee employeeAt2 = employees.ElementAtOrDefault(4);     // works same as ElementAt but will return null if index is not valid instead of throwing error.
            if(employeeAt2 != null)
                Console.WriteLine(employeeAt2.Id + " " + employeeAt2.Name);
            else
                Console.WriteLine("No employee");

            Console.WriteLine("----------------------------------------------------------------------");

            // Single / SingleOrDefault ----------------------------------------------------------------

            // It expect then there must be only one mathing element in source else it will throw exception.
            // This is the main difference between Single and First.

            //Employee employee = employees.Single(e => e.Name == "Shivam"); // will give error as there are multiple shivam
                                                                             // will also throw expection if no matching element is found

            Employee employee = employees.SingleOrDefault(e => e.Name == "xyz"); // works same as Single only it return null when no matching element is found instead of throwing exception.

            // Select -------------------------------------------------------------------------------------

            List<Person> people = employees.Select(emp => new Person() { personName = "xyz" }).ToList();
            foreach (Person person in people)
                Console.WriteLine(person.personName);

            Console.WriteLine("----------------------------------------------------------------------");

            // Min / Max / Count / Sum / Average -----------------------------------------------------

            int min = employees.Min(e => e.Id);
            int max = employees.Max(e => e.Id);
            int count = employees.Count(e => e.Id == 1);
            int sum = employees.Sum(e => e.Id);
            double average = employees.Average(e => e.Id);

            Console.WriteLine(min+" "+max+" "+count+" "+sum+" "+average);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Person
    {
        public string personName { set; get; }
    }
}
