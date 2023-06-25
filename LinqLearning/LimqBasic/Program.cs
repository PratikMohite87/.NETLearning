using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimqBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What is Linq ?

            //    Linq provides a way to query data using c#.
            //    Using linq you can query Collections, XML, ADO.NET Dataset, SQL Database, etc.

            //    Refer image : https://www.tutorialsteacher.com/Content/images/linq/linq-execution.PNG
            //                  https://www.tutorialsteacher.com/Content/images/linq/linq-usage.PNG

            // LINQ query must query to some kind of data sources whether it can be array, collections, XML or other databases.

            // Data source
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query Syntax 
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;

            // LINQ Method Syntax
            var myLinqQueryUsingFunc = names.Where(name => name.Contains('a'));

            foreach (var name in myLinqQuery) Console.WriteLine(name);
            foreach (var name in myLinqQueryUsingFunc) Console.WriteLine(name);

            Console.ReadLine();
            #endregion

            #region LINQ API

            // Sytem.Linq

            // We can write LINQ queries for the classes that implement IEnumerable<T> or IQueryable<T> interface.

            // LINQ queries uses extension methods for classes that implement IEnumerable or IQueryable interface.
            // The Enumerable and Queryable are two static classes that contain extension methods to write LINQ queries.

            #region Enumerable static class

            // The static Enumerable class includes extension methods for classes that implements the IEnumerable<T>
            //      interface. (e.g: https://www.tutorialsteacher.com/Content/images/linq/Enumerable.png)
            // IEnumerable<T> type of collections are in-memory collection like List, Dictionary, SortedList, Queue,
            //      HashSet, LinkedList.

            #endregion

            #region Queryable static class

            // The Queryable class includes extension methods for classes that implement IQueryable<t> interface. (e.g: https://www.tutorialsteacher.com/Content/images/linq/queryable.png)
            // The IQueryable<T> interface is used to provide querying capabilities against a specific data source
            //      where the type of the data is known.
            // For example, Entity Framework api implements IQueryable<T> interface to support LINQ queries with
            //      underlaying databases such as MS SQL Server. 

            #endregion

            #endregion

        }
    }

}
