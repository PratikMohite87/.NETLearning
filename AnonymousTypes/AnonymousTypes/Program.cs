using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // When u create an object with set of properties along with values; automatically C# compiler creates a class 
            // (with random name) with specified properties. It is called as 'anonymous type' or 'anonymous classes'
            // Anonymous classes are derived from System.Object class & are sealed classes.
            // By default all properties of anonymous class are readonly & public.
            // null can't be assigned to any property.

            var refVar = new { Name = "Pratik", Age = 24 };

            //refVar.Name = "Mohite"; error.

            // Nested AT

            var refVar2 = new { Property1 = 3, Property2 = new { NProperty1 = 4, NProperty2 = 5 } };


            // Anonymous array
            // array of anonymous objects.
            // Rule :- property must be same, datatype must be same, order must be same only values will be different else CTE.

            var refVar3 = new[] { new { Property1=1}, new { Property1 = 8} };
        }
    }
}
