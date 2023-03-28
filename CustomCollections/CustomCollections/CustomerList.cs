using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    // Custom Collection
    // i.e class which can store list of object like collections and have methods like add remove etc defined by developer.
    // we can add extra methods which are not in predefined collection we can add validations.
    internal class CustomerList2 : IEnumerable
    {
        private List<Customer> customers;

        public CustomerList2()
        {
            customers = new List<Customer>();
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                yield return customers[i];
            }
        }
    }

    // You can also create custom collection by implementing IEnumerable<T> intrface.
    // Similarly you can create custom collection by implementing ICollection, IList you meed to implement methods of that interface in you class.
    internal class CustomerList : IEnumerable<Customer>
    {
        private List<Customer> customers;

        public CustomerList()
        {
            customers = new List<Customer>();
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }

        public IEnumerator<Customer> GetEnumerator()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                yield return customers[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
