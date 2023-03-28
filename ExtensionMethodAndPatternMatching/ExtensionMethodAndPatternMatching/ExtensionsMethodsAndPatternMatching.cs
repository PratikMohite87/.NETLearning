using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodAndPatternMatching
{
    internal class ExtensionsMethodsAndPatternMatching
    {
        static void Main(string[] args)
        {
            //Extension Method : it is a method INJECTED (ADDED) into EXISITING CLASS (or struct or interface),
            //                   without modifiying the source code of that class (or struct or interface)

            // Consider, ClassName as exisiting class
            // static class ClassName
            // {
            //      public statuc ReturnType MethodName(this ClassName ParameterName, ...)
            //      {
            //          method body...
            //      }
            // }

            Product product = new Product() { ProductID = 1, DiscountPercentage = 10 };
            Console.WriteLine(product.GetDiscount());       // Extension Method called.

            // Developers will be able to added extra method to existing class without chnage source code.
            // 1st parameter must this keyword followed by classname/ struct name.
            // Extension method doesn't support method overriding its not a concept of inheritance.
            // Extension methods can be added to sealed class.
            // It CANT'T be used to create fields, properties or events.
            // Static class of extension method can't be inner class.




            // PatternMatching : It allows u to declare a variable, while checking the datatype (class) of reference variable,
            //                   and automatically type-casts the reference variable into specified data type (class).

            //if(referenceVariable is Class1)
            //{
            //   Class1 c1 = (Class1)referenceVariable;
            //   c1.property ..
            //}

            //------same as--------

            // if(referenceVariable is Class1 c1)           // Pattern Matching.
            // {
            //      c1.property..
            // }

            ParentClass parentClass = new ChildClass();
            parentClass.X = 1; // accessible.
            //parentClass.Y =2  // not accessible.

            if (parentClass is ChildClass c1)
            {
                c1.Y = 2;
            }



            // Implicitly type variable :
            //      var variable Name.
            //      dataype is decided by c# compiler at comile time.
            //      But once internally set dataype of that variable cannot be changed once declared.
            //      It can be only local variables, It can't be used as parameter name, return type or fields.
            //      Must be initialised along with declaration.
            //      Not possible to assign null to implicitly type var.

            var a = 10;
            //a = "Pratik"  gives error.



            // Dynamic type variable :
            //      Datatype will not be fixed u can change it .
            //      c# compiler skips type checking at compile time, it instead resolves the datatype of value at run time.
            //      Note : when you are assigning class object we need to check if property exist in class before using it.
            //             i.e Methods & other members of "dynamically typed variabe" will not be checked by compilier at compilation time,
            //                 will be checked by CLR are run time.
            //                 dynamictypeVar.NonExisitingMethod();    => RTE
            //      Its not compulsory to inisialize while declaring.
            //      dynamic type variables are converted as "object" type in most cases.
            //      Its allowed for local variables, method parameters, fields, properties, return types etc.

            //                  

            dynamic b = 10;     // int
            b = "Pratik";       // string       // no error.



            // Inner Class : Nested class.
            //               If private only accessible inside Outer class.
            //               If public accessible outside also. OuterClass.InnerClass
            //               By defaultits private.
            //               Outer class cannot access fields an members of inner class without creating its object and vice-versa. If done at same time then stackoverflowexception.  
            //               can create child class of inner class outside the outer class.
             
        } 
    } 
} 
 