// See https://aka.ms/new-console-template for more information

using LINQLearning;
using System.Collections;

int[] arrayOfInteger = { 23, 1, 44, 10, 15, 9, 33 };

#region LINQ Query Syntax

IEnumerable<int> ints = from value in arrayOfInteger
                        where value > 20
                        select value;

Console.WriteLine("LINQ Query Syntax :");
foreach(int value in ints)
    Console.WriteLine(value);

Console.WriteLine();

#endregion

#region LINQ Method Syntax

List<int> ints1 = arrayOfInteger.Where(i => i > 20).ToList();

Console.WriteLine("LINQ Method Syntax :");

foreach (int value in ints1)
    Console.WriteLine(value);

Console.WriteLine();

#endregion

#region LINQ Mixed Syntax

List<int> ints2 = (from value in arrayOfInteger
                   where value > 20
                   select value).ToList<int>();

Console.WriteLine("LINQ Mixed Syntax :");

int sum = (from value in arrayOfInteger
           where value > 20
           select value).Sum();

Console.WriteLine($"Sum : {sum}");

foreach (int i in ints2)
    Console.WriteLine(i);

Console.WriteLine();

#endregion

#region Functions

Console.WriteLine("Sum : " + ints.Sum());
Console.WriteLine("Min : " + ints.Min());
Console.WriteLine("Max : " + ints.Max());
Console.WriteLine("Count : " + ints.Count());
Console.WriteLine("Using Aggregate : " + ints.Aggregate((a, b) => a * b));

Console.WriteLine();

#endregion

#region Sorting Operators

List<Student> Objstudent = new List<Student>(){
        new Student() { Name = "Suresh Dasari", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
        new Student() { Name = "Rohini Alavala", Gender = "Female", Subjects = new List<string> { "Entomology", "Botany" } },
        new Student() { Name = "Praveen Kumar", Gender = "Male", Subjects = new List<string> { "Computers", "Operating System", "Java" } },
        new Student() { Name = "Sateesh Chandra", Gender = "Female", Subjects = new List<string> { "English", "Social Studies", "Chemistry" } },
        new Student() { Name = "Madhav Sai", Gender = "Male", Subjects = new List<string> { "Accounting", "Charted" } }
        };

var ascStudents = Objstudent.OrderBy(x => x.Name);
foreach (var obj in ascStudents)
    Console.WriteLine(obj.ToString());

Console.WriteLine();

var dscStudents = Objstudent.OrderByDescending(x => x.Name);
foreach (var obj in dscStudents)
    Console.WriteLine(obj.ToString());

Console.WriteLine();

var ascThenByStudents = Objstudent.OrderBy(x => x.Name).ThenBy(x => x.Gender);
foreach (var obj in ascThenByStudents)
    Console.WriteLine(obj.ToString());

Console.WriteLine();

var ascThenByDescStudents = Objstudent.OrderBy(x => x.Name).ThenByDescending(x => x.Gender);
foreach (var obj in ascThenByDescStudents)
    Console.WriteLine(obj.ToString());

Console.WriteLine();

foreach (int i in arrayOfInteger.Reverse())
    Console.Write(i + " ");

Console.WriteLine();

#endregion

#region Partition Operators

string[] countries = { "Uthopia", "Australia", "India", "USA", "Russia", "China", "Argentina" };

IEnumerable<string> li = countries.Take(3);
IEnumerable<string> li2 = (from city in countries select city).Take(3);

foreach (string city in li2)
    Console.WriteLine(city);

Console.WriteLine();

IEnumerable<string> li3 = countries.TakeWhile(city => city.EndsWith('a'));
foreach (string city in li3)
    Console.WriteLine(city);

Console.WriteLine();

IEnumerable<string> li4 = countries.Skip(3);
foreach (string city in li4)
    Console.WriteLine(city);

Console.WriteLine("----");

IEnumerable<string> li5 = countries.SkipWhile(city => city.EndsWith('a'));
foreach (string city in li5)
    Console.WriteLine(city);

Console.WriteLine();
#endregion

#region Conversion Operators

List<Employee> objEmployee = new List<Employee>()
            {
                new Employee(){ Name="Akshay Tyagi", Department="IT", Country="India"},
                new Employee(){ Name="Vaishali Tyagi", Department="Marketing", Country="Australia"},
                new Employee(){ Name="Arpita Rai", Department="HR", Country="China"},
                new Employee(){ Name="Shubham Ratogi", Department="IT", Country="USA"},
                new Employee(){ Name="Himanshu Tyagi", Department="IT", Country="Canada"}
            };

// here we will get collection of group of key/value pair.
// here key will be the thing (i.e Department) on which we are grouping.
//       value will be the collection of elements from datasource which falls umder that group.
var Emp = objEmployee.ToLookup(x => x.Department);

Console.WriteLine("Grouping Employees by Department");
Console.WriteLine("---------------------------------");
foreach (var KeyValurPair in Emp)
{
    Console.WriteLine(KeyValurPair.Key);
    // Lookup employees by Department  
    foreach (var item in Emp[KeyValurPair.Key])
    {
        Console.WriteLine("\t" + item.Name + "\t" + item.Department + "\t" + item.Country);
    }
}

Console.WriteLine();

//IEnumerable<double> castedString = arrayOfInteger.Cast<double>();
//foreach (var item in castedString)
//{
//    Console.WriteLine(item);
//}

ArrayList obj1 = new ArrayList();
obj1.Add("Australia");
obj1.Add("India");
obj1.Add("UK");
obj1.Add("USA");
obj1.Add(1);
//ofType() method will return the value only the specific type  
IEnumerable<string> result = obj1.OfType<string>();
//foreach loop is applied to print the value of the item  
foreach (var item in result)
{
    Console.WriteLine(item);
}

Console.WriteLine();

// ToList(), ToArray(), ToDictionary(), OfType<>(), AsEnumerable()
#endregion

#region Element Operators

Console.WriteLine(arrayOfInteger.First());  // Gets 1st value if not then throws exception.
Console.WriteLine(arrayOfInteger.First(x => x > 10));   // Gets 1st value which satisfies condition throws exception if not found.
Console.WriteLine(arrayOfInteger.FirstOrDefault(x => x == 1000));  // Gets 1st value which satisfies condition else returns default value if not found.

// Similar is the working of Last(), LastOrDefault(), ElementAt(index), ElementAtOrDefault(index)

// Single(), SingleOrDefault() :  read notes 

Console.WriteLine();

#endregion
