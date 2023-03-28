using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDatatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables is a named memory location in RAM, to store a particular type of value during program execution.
            // Variables are stored in stack.
            // For every method call a new stack will be created.
            //      For e.g : For Main() method variables there will be separate stack.
            //                Method called from Main() mathod will have its separate stack.
            //                Once method execution is completed stack is deleted automatically.
            // Datatype of variable cannot be changed once declared.
            // Variable value can be changed any no of times.

            int number;             // Declaration
            number = 10;            // Initialization
            Console.WriteLine(number);

            int number2 = 100;      // Declaration + Initialization
            Console.WriteLine(number2);

            //-----------------------------------------------------------------------------

            // Primitive Types

            // sbyte : 8-bit signed integer
            //         Size : 1 byte
            //         Range : -128 to 127
            //         Default value : 0
            Console.WriteLine(sbyte.MinValue+" "+sbyte.MaxValue);

            // byte : 8-bit un-signed integer
            //        Size : 1 byte
            //        Range : 0 to 255
            //        Default value : 0
            Console.WriteLine(byte.MinValue + " " + byte.MaxValue);

            // short : 16-bit signed integer
            //        Size : 2 byte
            //        Range : -32768 to 32767
            //        Default value : 0
            Console.WriteLine(short.MinValue + " " + short.MaxValue);

            // ushort : 16-bit u-signed integer
            //          Size : 2 byte
            //          Range : 0 to 65535
            //          Default value : 0
            Console.WriteLine(ushort.MinValue + " " + ushort.MaxValue);

            // int : 32-bit signed integer
            //          Size : 4 byte
            //          Range : -2,147,483,648 to 2,147,483,647
            //          Default value : 0
            // By default integer literals between range are treated as "int" datatype.
            Console.WriteLine(int.MinValue + " " + int.MaxValue);

            // uint : 32-bit un-signed integer
            //          Size : 4 byte
            //          Range : 0 to 4,294,967,295
            //          Default value : 0
            // By default integer literals between 2,147,483,648 to 4,294,967,295 are treated as "int" datatype.
            Console.WriteLine(uint.MinValue + " " + uint.MaxValue);

            // long : 64-bit signed integer
            //        size : 8 bytes
            //        Range : -2^63 to 2^63-1
            //        Default value : 0
            // By default integer literals between 4,294,967,296 to 2^63-1 are treated as "long" datatype
            Console.WriteLine(long.MinValue + " " + long.MaxValue);

            // ulong : 64-bit un-signed integer
            //        size : 8 bytes
            //        Range : 0 to 18,446,744,073,709,551,615
            //        Default value : 0
            // By default integer literals between 2^63+1 to 18,446,744,073,709,551,615 are treated as "long" datatype
            Console.WriteLine(ulong.MinValue + " " + ulong.MaxValue);

            // float : 32-bit signed floating-point number
            //         size : 4 bytes
            //         Range : -3.402823E + 38 to 3.402823E + 38
            //         Precision : 7 digits
            //         Default value : 0F
            Console.WriteLine(float.MinValue + " " + float.MaxValue);

            // double : 64-bit signed floating-point number
            //         size : 8 bytes
            //         Range : -1.79769313486232E + 308 to 1.79769313486232E + 308
            //         Precision : 15 digits
            //         Default value : 0D (but we can avoid using suffix D, it will be cosidered as double.)
            // By default integer literals between range are treated as "double" datatype.
            Console.WriteLine(double.MinValue + " " + double.MaxValue);

            // decimal : 128-bit signed floating-point number
            //           size : 16 bytes
            //           Precision : 28 digits
            //           Default value : 0M
            Console.WriteLine(decimal.MinValue + " " + decimal.MaxValue);

            // char : 16-bit Single Unicode character
            //        written in '' exg. 'A'
            //        size : 2 bytes
            //        Range : 0 to 137,994 (Unicode codes that represent characters)
            //                              ASCII = 0 to 255 (English lang characters only)
            //                              Unicode = ASCII + Worlds other natural lang characters
            //        Default value : \0 => null

            // bool : Stores logical true/false
            //        size : 1 bit
            //        Default value : false

            //-----------------------------------------------------------------------------

            // Non-Primitive Types

            // string : Collection of uncode characters
            //          written in "" exg. "abcd"
            //          size : length * 2
            //          Range : 0 to 2billion characters
            //          Default value : null

            //-----------------------------------------------------------------------------

            // if you what dafault value of any datatype then.
            Console.WriteLine(default(int));


            int a = 10;
            int b = --a;//a--;//++a;//a++;
            Console.WriteLine(a+" "+b);

            bool c = a == 10 & b == 9;      // single & will chck both side even if 1s part is false.
            bool d = a == 10 && b == 9;     // double && will not check second side if 1st part is false.
            Console.WriteLine(c+" "+d);

            bool e = a == 9 | b == 9;       // single | will check both side even if 1st part is true.
            bool f = a == 9 || b == 9;      // double || will not check second side if 1st part is true.
            Console.WriteLine(e + " " + f);

            //Console.ReadKey();

        }
    }
}
