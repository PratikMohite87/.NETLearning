using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // System.Object class is pre-defined class, "ULTIMATE SUPER CLASS (Base class)" in .net

            //                                  class System.Object
            //                                  /         \         \
            //           class System.ValueType         Classes      Interfaces
            //                /          \
            //         Structures       Enumerations


            // Following are the methods of object class which can me override accordingly in our class.

            //namespace System
            //{
            //    class Object
            //    {
            //          virtual bool Equals(object value);
            //          virtual int GetHashCode();
            //          Type GetType();
            //          virtual string ToString();
            //    }
            //}

            Person person = new Person() { Name = "Pratik", age = 9 };
            Person person1 = new Person() { Name ="Chinamy", age = 9 };
            Console.WriteLine(person1.Equals(person));
            Console.WriteLine(person.ToString());
            Console.WriteLine(person.GetHashCode()+" "+person1.GetHashCode());      // Gets memory address of object person, we can override also
            Console.WriteLine(person.GetType());


            // Boxing : Conversion from value type to Reference type.
            //          This is done automatically no syntax required.

            int x = 10;

            // System.Object is class and "object is keyword for it."
            object y = x; // Boxing (Automatic)
            Console.WriteLine(x.GetType());
            Console.WriteLine(y.GetType());

            // Unboxing : Converson from Reference type to Value-Type.
            //            Happens only when datatypes are compatible.
            //            i.e when primitive type is a child of reference tyep
            //            Explicit casting is required for unboxing.

            int c = (int)y;  // Unboxing.
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int age { get; set; }

        public override bool Equals(object obj)
        {
            Person p = obj as Person;
            if (this.Name == p.Name && this.age == p.age)
                return true;
            else
                return false;
        }

        public override int GetHashCode() { return 0; }

        public override string ToString()
        {
            return this.Name+" "+this.age;
        }
    }
}
