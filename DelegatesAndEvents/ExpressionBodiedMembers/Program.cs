using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Expression Bodied Members :
            //      This concept allows the developer to use "Inline Lambda Expressions" to create methods,
            //      property accessors, constructors, destructors, indexers in a class.
            //      Only help full when code is of one liner.
            //      Does not eefects speed of excution

            Student student = new Student("Pratik");
            Console.WriteLine(student.GetStudentNameLength());
            student.StudentName = "Chinmay";
            Console.WriteLine(student.GetStudentNameLength());



        }
    }

    public class Student
    {
        private string _studentName;

        // One linear properties
        public string StudentName
        {
            set => _studentName = value;
            get => _studentName;
        }

        // Oneliner Constructor
        public Student(string name) => _studentName = name;

        // Oneliner Method
        public int GetStudentNameLength() => _studentName.Length;


    }
}
