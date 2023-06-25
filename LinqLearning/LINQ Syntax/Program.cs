using LINQ_Syntax;
using System.Collections.Generic;


IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };

#region LINQ Query Syntax

    #region Syntax

    /*
    from < range variable > in < IEnumerable < T > or IQueryable<T> Collection>
    <Standard Query Operators> <lambda expression>
    <select or groupBy operator> <result formation>
    */

    #endregion

// LINQ Query Syntax to find out teenager students
var teenAgerStudent = from s in studentList
                      where s.Age > 12 && s.Age < 20
                      select s;

foreach (var a in teenAgerStudent) Console.WriteLine(a.ToString());

#endregion

#region LINQ Method Syntax

    #region Syntax

    // dataSource.ConditionMehtods().SelectionMethods()

    #endregion

var teemAgerStudent2 = studentList.Where(student => student.Age > 12 && student.Age < 20).ToList();

foreach (var a in teemAgerStudent2) Console.WriteLine(a.ToString());

#endregion

#region LINQ Mixed Syntax

#region Syntax

/*
(from < range variable > in < IEnumerable < T > or IQueryable<T> Collection>
<Standard Query Operators> <lambda expression>
<select or groupBy operator> <result formation>).Method()
*/

#endregion

double average = (from student in studentList
               where student.Age > 12 && student.Age < 20
               select student.Age).Average();

Console.WriteLine(average);

#endregion