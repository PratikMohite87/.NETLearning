using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollection
{
    internal class BitArrayLearning
    {
        // The BitArray class manages a compact array of bit values, which are represented as Booleans, where true indicates that the bit is on i.e, 1 and false indicates the bit is off i.e, 0.
        // This class is contained in System.Collections namespace.
        // The BitArray class is a collection class in which the capacity is always the same as the count.
        // Elements are added to a BitArray by increasing the Length property.
        // Elements are deleted by decreasing the Length property.
        // Elements in this collection can be accessed using an integer index.Indexes in this collection are zero-based.

        static void Main()
        {
            // Creating a BitArray
            BitArray myBitArr = new BitArray(5);

            myBitArr[0] = true;
            myBitArr[1] = true;
            myBitArr[2] = false;
            myBitArr[3] = true;
            myBitArr[4] = false;

            // To get the value of index at index 2
            Console.WriteLine(myBitArr.Get(2));

            // To get the value of index at index 3
            Console.WriteLine(myBitArr.Get(3));
        }
    }
}
