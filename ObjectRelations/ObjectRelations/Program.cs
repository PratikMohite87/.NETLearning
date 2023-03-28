using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using College;

namespace ObjectRelations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // One-To-One

            Branch branch = new Branch();
            branch.BranchId = 1;
            branch.BranchName = "AI";

            Student student = new Student();
            student.StudentId = 1;
            student.Name = "Pratik";
            student.Branch = branch;

            Console.WriteLine(student.StudentId+" "+student.Name+" "+student.Branch.BranchId+" "+student.Branch.BranchName);

            // One-To-Many

            List<Examination> examinations = new List<Examination>() { 
                new Examination() { ExaminationId=1, ExaminationName="Maths", Marks=100},
                new Examination() { ExaminationId=2, ExaminationName="Maths-2", Marks=101}
            };

            student.examinations = examinations;

            foreach (Examination examination in student.examinations)
                Console.WriteLine(examination.ExaminationId + " " + examination.ExaminationName + " " + examination.Marks);


            // Many-To-One

            // Consider one-to-one example.
            // If you see from Student perspective its 1-to-1, as 1 student have 1 branch.
            // But, if you see from Branch class perspective its Many-To-One, as Many student can have 1 branch.
        }
    }
}
