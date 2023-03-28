using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatableInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contains() method matches object and not the values inside the object,
            // so when objects are different but values inside it are same the also it will give false.
            // So we use IEquatable interface so that we can write logc to identify whhether objects are equal or not.
            // Contains() method calls Equals method internally to match.

            Customer customer = new Customer() { Id = 1, Name = "Pratik" };
            Customer customer2 = new Customer() { Id = 2, Name = "Chinmay" };
            Customer customer3 = new Customer() { Id = 1, Name = "Pratik" };

            Console.WriteLine(customer.Equals(customer3));
            Console.WriteLine(customer.Equals(customer2));

        }
    }

    public class Customer : IEquatable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals(Customer other)
        {
            return Id == other.Id && Name == other.Name;
        }
    }

    public class Customer2
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object other)
        {
            return Id == ((Customer2)other).Id && Name == ((Customer2)other).Name;
        }
    }
}
