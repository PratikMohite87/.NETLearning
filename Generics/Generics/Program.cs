using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic Class : class which contains one or more "type parameters".
            //                 U can pass any datatype (standard/structure/class).

            // class ClassName<T>
            //{
            //    public T FieldName;
            //}

            // ClassName<int> refVar = new ClassName<int>();

            // U an have Generic classes, methods, interfaces & delegates.
            // .NET framework class linrary contains many new generic collection classes in System.Collections.Generic namespace.

            //class ClassName<T1, T2>
            //{
            //    public T1 RegistrationStatus;
            //    public T2 RegistrationStatus2;
            //}

            // ClassName<int, string> refVar = new ClassName<int, string>();

            // Generic Constraint.
            // Restriction that what datatype u can pass.
            // where T : class      => will accept any class
            // where T : struct
            // where T : ClassName  => will accept specific class only.
            // where T : Interface
            // where T : new()

            //class ClassName<T1, T2> where T  : class
            //{
            //    public T1 RegistrationStatus;
            //    public T2 RegistrationStatus2;
            //}


            // Generic Method :
            // public void MethodName<T1,T2>(T1 obj) where T1 : class
            // {
            //      code
            // }
        }
    }
}
