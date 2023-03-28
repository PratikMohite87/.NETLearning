using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Access Modifiers which can be attached to Methods : (scope are same as fields)
            //      private, protected, private protected, internal, protected internal, public.

            // Modifiers which can be attached : (are optional)
            //      static,
            //      virtual,
            //      abstract,
            //      override,
            //      new,
            //      partial,
            //      sealed

            // Encapsulation : it is a concept that binds data & operations that manipulates that data,
            //                 this keeps both safe from outside interference and misuse.
            //                 i.e class which is a combination of fields and methods.
            //                 this also includes accessing fields through setter and getter methods.


            // Abstraction : it is a concept of providing only limited data or operations to the code exist outside of class.
            //               it is a concept of hiding some "private data / operations" & providing some "public data / operations" to the code outside of class.
            //               i.e combination of private fields and public method and accessing private fields through public methods is the implementation of abstraction.

            // "this" keyword : refers to "current object"

            // static methods : used to operate with static fields.
            //                  Instance methods can access both static & instance fields/methods, whereas static method can ONLY ACCESS STATIC FIELDS/METHODS.
            //                  

            // Default argument

            DefaultValueMethods(100);
            DefaultValueMethods();

            // Named Arguments
            NamedArgumentMethods(first: 10, third: 50, second: 30);
            NamedArgumentMethods(60, second: 46, third: 99);
            NamedArgumentMethods(first: 110, 44, 55);
            NamedArgumentMethods(60, second: 46, 99);


            // Method Overloading : Writing multiple methods with same name in the same class, with different parameters.

            // Parameter Modifiers :

            // ref : If parameter value changes in method then calling argument value also changes.
            //       Argument must be variable & must be initialised, should also write ref while calling.
            int a = 10;
            Console.WriteLine(a);
            RefMethod(ref a);
            Console.WriteLine(a);

            // out : value of parameter goes to calling argument.
            //       i.e variable passed as argument can be non-initialisd

            string b;
            OutMethod(out b);
            Console.WriteLine(b);

            //       we can return multiple values like one through return and others through out.
            //       variable declaration can be inlined. (c# 7.0)
            string c;
            c = OutMethod2(out string d, out string e);
            Console.WriteLine(d+" "+c+" "+e);


            // in : Argument will be assigned to parameters but parameter becomes READ-ONLY.
            //      We cannot modifiy value of parameter in the method; if you try to change cte will be shown.

            int f = 10;
            InMethod(in f);


            // ref return (c# 7.3) : whenever you want to return reference of variable with its value rather than only value you us ref return.
            //              value change after returning will affet thw original one.
            Student s = new Student();
            Console.WriteLine(s.ReturnGrade());

            ref int referenceValue = ref s.ReturnRefOfVariable();
            Console.WriteLine(referenceValue);
            referenceValue = 100;
            Console.WriteLine(s.ReturnGrade());


            // params : All set of arguments will be at-a-time received as an array into the parameter.
            //          it can be only used for the last parameter of the method.
            //          it can be only used once for one method.
            ParamsMethod(1, 2, 3, 4, 5, 7, 8, 9);

            // Local functon : Function which is called and written in method and limited to it..
            //                 they does not have access mofifier.
            //                 reuseablity is the benefit.
            //                 local function can access all the local variable and paramter of its parnt method.

            // static local function : same as local function but here local variable and paramters will be not accessible to static local function.
            //                         if you want paamters the while calling static local function you need to pass as arguments.
        }

        public static void DefaultValueMethods(int value = 10)
        {
            Console.WriteLine(value);
        }

        public static void NamedArgumentMethods(int first,int second,int third)
        {
            Console.WriteLine(first + " " + second + " " + third);
        }

        public static void RefMethod(ref int value)
        {
            Console.WriteLine("From Method");
            value++;
            Console.WriteLine(value);

        }

        public static void OutMethod(out string value)
        {
            value = "Pratik";
        }

        public static string OutMethod2(out string value1, out string value2)
        {
            value1 = "Pratik";
            value2 = "Mohite";
            return "Tukaram";
        }

        public static void InMethod(in int value)
        {
            Console.WriteLine(value);       // you can access value
            //value = 100;                    // but you cannot change it. will give cte
        }

        public static void ParamsMethod(params int[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                Console.Write(parameters[i] + " ");
            }
        }
    }

    class Student
    {
        int grade = 10;

        public int ReturnGrade()
        {
            return grade;
        }

        public ref int ReturnRefOfVariable()
        {
            return ref grade;
        }
    }
}
