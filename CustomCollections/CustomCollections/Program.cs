using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { CustomerId=101, CustomerName="Chinmay", CustomerType = TypeOfCustomer.RegularCustomer};
            Customer customer2 = new Customer() { CustomerId = 102, CustomerName = "Chinmay-2", CustomerType = TypeOfCustomer.VipCustomer };

            CustomerList customerList = new CustomerList();
            customerList.Add(customer);
            customerList.Add(customer2);

            IEnumerator enumerator = customerList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(((Customer)enumerator.Current).CustomerId);
            }

            //      OR

            foreach (Customer cust in customerList)
            {
                Console.WriteLine(cust.CustomerId);
            }

            customerList.Remove(customer);

            foreach (Customer cust in customerList)
            {
                Console.WriteLine(cust.CustomerId);
            }

        }
    }
}
