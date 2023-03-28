using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Types (structures, enumerations) :
            //      are by default NON-NULLABLE types.

            // Reference Types (classes, Interfaces) :
            //      are by default NULLABLE types.

            // T? is shorthand for Nullable<T> it means value type can accept null as value.
            int? a = null;  // no error.

            // Null Coalescing Operator:
            //      It returns LHS operand if value is not null and vice-versa.
            //      variableName ?? valueIfNull.


            // Null Propogation Operator (?. & ?[]):
            // ?. :
            //      referenceVariable?.fieldName;
            //      ------is same as-------------
            //      (referenceVariable == null)? null : referenceVariable.fieldName;
        }
    }
}
