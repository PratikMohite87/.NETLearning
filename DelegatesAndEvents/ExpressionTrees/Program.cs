using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Expression Trees : 
            //      it is a collection of delegates reperesented in tree-like structure.
            //      only executes when w ecompile & execute it.
            //      supports all delegates types such as Func, Action, Predicate or Custom delegate types.
            //      DEVELOPER do not use this , its used internally in linq ,

            // Create Expression tree  with Func
            Expression<Func<int, int>> expression = a => a * a;

            // Compile expression to nvoke it as delegate
            Func<int, int> myDelegate = expression.Compile();

            // Execute the method
            int result = myDelegate.Invoke(10);

            Console.WriteLine(result);

            //------------------------------------------------------------------------------------------------

            Student student = new Student() { Age = 13, Id = 1, Name = "Pratik" };

            Expression<Predicate<Student>> expression1  = s => s.Age > 10;

            Predicate<Student> myDelegate2 = expression1.Compile();

            Console.WriteLine(myDelegate2.Invoke(student));
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }
    }
}
