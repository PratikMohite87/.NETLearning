using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    internal class Product
    {
        //fields
        // What are fields ?
        //      Variables that are declare in class; stored in object.
        // Default access modifier of field is private.

        public int productId;
        public string productName;
        public double price;
        public int quantityInStock;

        // static fields:
        // it is not stored in object it is stored in class memory which is created in heap.
        // it will be common for all objects.
        // memory is allocated only once when class name is mentioned in program.

        public static int count;

        // constant fields:
        // constants are common to all object like static but we cannot change its value once initialised.
        // are accesible will class name NOT WITH Object
        // constant fields are not stored anywhere nor in object nor in class memory.
        // constant fields must be initialised in line with declaration.

        public const int no = 322;

        // readonly fields:
        // are instance fields, stored in every object.
        // can be accessed by object only.
        // its value cannot be changed.
        // Must be inisilised in line with declaration or in constructor.
        // readonly field value can differ for ech object but will remain fixed for that object till end.

        public readonly int age = 600;
    }
}
