using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Query_Operators
{
    internal class Average_Count_Max_Sum_Learnings
    {
        public static void Main10(string[] args)
        {
            #region Average

            IList<int> intList = new List<int> () { 10, 20, 30 };

            var avg = intList.Average();
            Console.WriteLine("Average: {0}", avg);

            IList<Student> studentList = new List<Student> () {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
            };

            var avgAge = studentList.Average(s => s.Age);
            Console.WriteLine("Average Age of Student: {0}", avgAge);

            #endregion

            #region Count

            IList<int> intList2 = new List<int>() { 10, 21, 30, 45, 50 };

            var totalElements = intList.Count();
            Console.WriteLine("Total Elements: {0}", totalElements);

            // Counting based on condition
            var evenElements = intList.Count(i => i % 2 == 0);

            Console.WriteLine("Even Elements: {0}", evenElements);

            #endregion

            #region Max

            IList<int> intList3 = new List<int>() { 10, 21, 30, 45, 50, 87 };

            var largest = intList.Max();
            Console.WriteLine("Largest Element: {0}", largest);

            // Getting Max from elements satisfing certain condition
            var largestEvenElements = intList.Max(i => {
                if (i % 2 == 0)
                    return i;

                return 0;
            });

            Console.WriteLine("Largest Even Element: {0}", largestEvenElements);

            #endregion

            #region Sum

            IList<int> intList4 = new List<int>() { 10, 21, 30, 45, 50, 87 };

            var total = intList.Sum();
            Console.WriteLine("Sum: {0}", total);

            var sumOfEvenElements = intList.Sum(i => {
                if (i % 2 == 0)
                    return i;

                return 0;
            });

            Console.WriteLine("Sum of Even Elements: {0}", sumOfEvenElements);

            #endregion
        }
    }
}
