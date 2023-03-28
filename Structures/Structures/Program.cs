using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct();
            myStruct.x = 10;
            myStruct.y = 20;
            Console.WriteLine(myStruct.x+" "+myStruct.y);


            // REMEBER : Unlike class, struct object can be created without using new() operator.
            //            in this case all fields of the struct will remain unassigned
            //            and the object can't be used until all of the fields are INITIALIZED. 
            MyStruct myStruct1;
            myStruct1.x = 10;
            myStruct1.y = 20;
            Console.WriteLine(myStruct1.x + " " + myStruct1.y);

            // Accessing static fields.
            //Console.WriteLine(myStruct1.z);     // CTE : Static field can be accessed using object.
            Console.WriteLine(MyStruct.z);

            
            // Accessing Static Methods
            //myStruct1.SetZ(100);    // as W and data field are uninitialised hence giving error & we have not created object using constrcutor so w and data are not getting initialised.
            Console.WriteLine(MyStruct.ManipulateStaticField());

            // Method Overloading
            myStruct.SetXY(100,150);
            Console.WriteLine(myStruct.x + " " + myStruct.y);
            myStruct.SetXY(1000);
            Console.WriteLine(myStruct.x + " " + myStruct.y);


            // Constructor overloading.
            MyStruct myStruct2 = new MyStruct();
            Console.WriteLine(myStruct2.x + " " + myStruct2.y);

            MyStruct myStruct3 = new MyStruct(222, 333);
            Console.WriteLine(myStruct3.x + " " + myStruct3.y);

            MyStruct myStruct4 = new MyStruct(222);
            Console.WriteLine(myStruct4.x + " " + myStruct4.y);


            myStruct4.data = new string[] { "Pratik", "Tukaram", "Mohite" };
            Console.WriteLine(myStruct4[0]+" "+myStruct4[1]+" "+myStruct4[2]);

            MyStruct myStruct5 = -myStruct4;
            Console.WriteLine(myStruct5.x+" "+myStruct5.y);


            // Inheritance is not possible in struct
            // There is no inheritance for structs as there is for classes.
            // A struct can't inherit from another struct or class and it can't be the base class for a class.
            // But remember that in C# all types are directly or indirectly inheriting from the super base class object and hence the structure also.
            // Since structs doesn't support inheritance, we can't use the keywords virtual,
            //                                                                      override,
            //                                                                      new,
            //                                                                      abstract etc with a struct methods.
            // C# struct types are never abstract and are always implicitly sealed.
            // The abstract or sealed modifiers are not permitted in a struct declaration. 
            // Since inheritance is not supported for structs, the declared accessibility of a struct member can't be protected or protected internal.
            // Since all struct types are implicitly inherit from object class, it is possible to override the methods of the object class inside a struct by using the keyword override.

            ClassLibrary1.ReadOnlyStructure readOnlyStructure = new ClassLibrary1.ReadOnlyStructure("Pratik");
            readOnlyStructure.PrintCharacterName();

            // NOTE : All PRIMITIVE types are Structures.
            //        rEFER pic.
        }
    }
}
