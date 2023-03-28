using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tuple Class : 
            //      Cannot pass unlimited values.
            //      Cannot have property name, need to access through item1, item2, ....etc
            //      Can be used as an alternative to anonymous class

            Tuple<int> tuple = new Tuple<int>(1);
            Tuple<int> tuple2 = new Tuple<int>(1);
            Tuple<int> tuple3 = new Tuple<int>(1);
            Tuple<int> tuple4 = new Tuple<int>(2);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.GetHashCode());
            Console.WriteLine(tuple2.GetHashCode());
            Console.WriteLine(tuple3.GetHashCode());
            Console.WriteLine(tuple4.GetHashCode());

            ArrayList arrayList = new ArrayList() { Tuple.Create<int,int>(1,2),
            Tuple.Create<int,int>(2,3),
            Tuple.Create<int,int>(4,5)
            };

            Console.WriteLine(arrayList.Contains(new Tuple<int,int>(2,3)));


            // Value Tuples : 
            //      Advancement to 'Tuple' class (c# 7.1)
            //      Supports unlimited values.
            //      Can give property name, not bounded to item1....

            Customer customer = new Customer();

            (int customerID, string customerName, string email) valueTuple = customer.GetCustomer();
            Console.WriteLine(valueTuple.customerName+" "+valueTuple.customerID+" "+valueTuple.email);


            // Deconstruction : 
            //      Allows u to assign elements of value tuple into individual local variable.
            //      Order matters

            (int customerID, string customerName, string email) = customer.GetCustomer();
            Console.WriteLine(customerName + " " + customerID + " " + email);           // these 3 are now local  variables of main method

            //OR

            (int localCustId, string localCustName, string LocalEmail) = customer.GetCustomer();
            Console.WriteLine(localCustId + " " + localCustName + " " + LocalEmail);


            // Discard : 
            //      allows you to skip a value you dom't require, by using _

            (int localCustId2, _,_) = customer.GetCustomer();
            Console.WriteLine(localCustId2);
        }
    }

    public class Customer
    {
        public (int customerID, string customerName, string email) GetCustomer()
        {
            return (101, "xyz", "abc@gmail.com");
        }
    }
}
