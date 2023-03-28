using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Casting : lower-numerical-type can be AUTOMATICALLY ( IMPLICITLY ) converted into higher-numerical-type
            //                    refer casting table in pic.
            sbyte a = 10;
            int b = a;      // implicit casting

            char c = 'a';
            int d = c;
            Console.WriteLine(b+" "+d);


            // Explicit Casting : We can manually convert a value from one data type to another datatype, by specifying the 
            //                    destination datatype within bracket, at lhs of the source value.
            //                    e.g : (DestinationDataType)SourceValue

            //                    Loosy Conversion : If destination type is not sufficient enough to store the converted value,
            //                                       the value may loose.

            int g = 500;
            byte h = (byte)g;       // loosy conversion
            Console.WriteLine(h);

            //                    Implicit Casting can be done with explicit casting.

            sbyte e = 10;
            int f = (int)e;
            Console.WriteLine(f);

            //                    refer casting table in pic.
            //                    We can convert child class to parent class using Explicit casting.



            // Parsing : STRING value can be converted into any NUMERICAL datatype, but string must contains digit only
            //           else FormatException.
            //           When u are sure thar source value does not contain any special characters, characters, space then 
            //           u can go for Parse method, else go for TryParse.

            string value = "1000";
            Console.WriteLine(int.Parse(value)+" "+double.Parse(value));


            // TryParse : It does not throw format exception
            //            It first chek wheter string can be converted or not ?
            //            If yes then it converts it and return in out variable & its return type will be true.
            //            If not then out variable will be set to default value 0 & will return false.

            string value2 = "3646h46";
            if (int.TryParse(value2, out int result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid Characters");
                Console.WriteLine(result);
            }


            // Convert : predefined methods which converts any primitive type(also string) to any other primitive type(also string).
            //           System.Convert class contains these static methods.
            //           Refer Pic to see these methods.

            int value3 = 10000;
            Console.WriteLine(Convert.ToString(value3));

        }
    }
}
