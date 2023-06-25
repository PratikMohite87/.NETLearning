using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class Where_Learnings
    {
        public static void Main1(string[] args)
        {

            #region Where method Overloads:
            /*
             * public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, 
                                              Func<TSource, bool> predicate);

                public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, 
                                              Func<TSource, int, bool> predicate);
             */
            #endregion

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            #region Where clause in Query Syntax

            var filteredResult = from stud in studentList
                                 where stud.Age > 12 && stud.Age < 20
                                 select stud;

            // In the above sample query, the lambda expression body s.Age > 12 && s.Age < 20 is passed as a
            //      function Func<TSource, bool>

            // We can also do

            Func<Student, bool> condition = delegate (Student s)
            {
                return s.Age < 12 && s.Age < 20;
            };

            var filteredResult2 = from stud in studentList
                                  where condition(stud)
                                  select stud;

            // So you can say that you can call any method satisfying Func (i.e bool return type)
            //      after where.

            #endregion

            #region Where clause in Method Syntax

            var filteredResult3 = studentList.Where(stud => stud.Age > 12 && stud.Age < 20);

            // Where extension method also have second overload that includes index of current element in the collection.
            // You can use that index in your logic if you need.

            var filteredResult4 = studentList.Where((s, i) =>
            {
                if (i % 2 == 0) return true;

                return false;
            });

            #endregion

            #region Multiple Where clause in single Query

            var filteredResult5 = from s in studentList
                                 where s.Age > 12
                                 where s.Age < 20
                                 select s;

            var filteredResult6 = studentList.Where(s => s.Age > 12).Where(s => s.Age < 20);

            #endregion

            foreach (var s in filteredResult4) Console.WriteLine(s.ToString());

        }
    }
}
