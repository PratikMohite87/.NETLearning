using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary2;

namespace PartialClassAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Partial class : class that splits into multiple files, each file is treated as part of class.
            //                 This allows multiple developer to work on same class differently.
            //                 We will see different classes but it will be one class.

            // we have created partial class class1 in 3 different files class1 class2 class3 in classlibrary1.
            // At compilation time all partial classes are combined as single class.
            // namespaces of all partial classes must be same otherwise they will be treated as different class.
            // duplicate members are not allowed in partial classes becoz both will be part of same class.

            Class1 class1 = new Class1();
            class1.ProductId = 1;
            class1.Cost = 2334.3;
            Console.WriteLine(class1.GetTax());


            // Partial methods are declared in one partial class (just like abstract method ) & implemented in another partial class
            // that have same name.
            // Partial methods are private by default, so it needs to be called from another public method.
            // Can have only void return type.

            class1.CallPartialMethod();


            // static class : class that ONLY contains STATIC members.
            // In real time project you will have need to store common ting so for that purpose you can use static class.

            StaticClass.GetNo();

            // Enumeration : it is a collection of constants.
            //               is used to specify list of options allowed to be stored in a field/variable.
            // Goal : use enum if you don`t want to allow other developers to assign other value into a field/variable, other than 
            //        the list of values specified in the enumeration.
            // for every constant in enum there is integer value behind it, default start from 0.
            // We can explicitly provide value.
            // We can also store datatype of enum.

            Person person = new Person();
            person.PersonName = "Pratik";
            person.Email = "xyz";
            person.AgeGroup = AgeGroupEnum.Teenager;
            Console.WriteLine(person.PersonName+" "+person.Email+" "+person.AgeGroup);
        }
    }
}
