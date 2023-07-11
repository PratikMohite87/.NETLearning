using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Why do we Need IComparable ?

            // During implementation, often question rises on how to sort a collection of objects.
            // To sort a collection requires how objects can first of all be compared to each other.
            // A value type such as int, double, float can be compared if both of the objects have equal values.
            // However, a reference type such as a class with multiple fields, the question is often difficult to answer.
            // Well, in other words it depends. It depends how two objects are said to be compared / equated;
            //      when all fields have the same value or one of them is enough to decide if they are equal.

            #endregion

            #region IComparable Interface:

            //  Interface has a CompareTo method that takes a reference type as a parameter and returns an integer based on if current instance precedes, follows or occurs in the same position in the sort order as the other object(MSDN).
            //  The implementation of the CompareTo(Object) method must return an Int32 that has one of the three values, as in the following table.

            //  Value               Meaning

            //  Less than zero      The current instance precedes the object specified by the CompareTo method in the sort order.
            //  Zero                This current instance occurs in the same position in the sort order as the object specified by the CompareTo method.
            //  Greater than zero   This current instance follows the object specified by the CompareTo method in the sort order.

            Car[] cars = new Car[]
            {
                new Car()
                {
                    Name = "Zinco"
                }, new Car()
                {
                    Name = "VW"
                }, new Car()
                {
                    Name = "BMW"
                }
            };

            //Array.Sort(cars);
            //Array.ForEach(cars, x => Console.WriteLine(x.Name));

            #endregion

            #region Why do we need IComparer ?

            // IComparable is going to help until you have complete control of user-defined class,
            // but let's say you want to apply sorting on a class on which you don't have control.

            // Meaning you can't change the implementation of a class; e.g.,
            // when you access some class from DLL, you can use them but you can't change their implementation.

            // In order to achieve sorting on such classes, the IComparer interface was born.

            #endregion

            #region IComparer interface :

            // The CompareTo method from IComparable interface can sort on only one field at a time, so sorting on different properties with it is not possible.
            // IComparer interface provides Compare method that Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
            // A class that implements the IComparer interface must provide a Compare method that compares two objects.

            var carComparer = new CarComparer();
            carComparer.compareField = CarComparer.SortBy.MaxSpeed;
            Array.Sort(cars, carComparer);
            Array.ForEach(cars, x => Console.WriteLine(x.Name));

            #endregion
        }
    }

    public class Car : IComparable
    {
        public string Name
        {
            get;
            set;
        }
        public int MaxSpeed
        {
            get;
            set;
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Car))
            {
                throw new ArgumentException("Compared Object is not of car");
            }
            Car car = obj as Car;
            return Name.CompareTo(car.Name);        // THIS CompareTo method is default one it goes  leter by letter in case of string and numbers.
        }
    }

    public class CarComparer : IComparer<Car>
    {
        public enum SortBy
        {
            Name,
            MaxSpeed
        }
        public SortBy compareField = SortBy.Name;
        public int Compare(Car x, Car y)
        {
            switch (compareField)
            {
                case SortBy.Name:
                    return x.Name.CompareTo(y.Name);
                    break;
                case SortBy.MaxSpeed:
                    return x.MaxSpeed.CompareTo(y.MaxSpeed);
                    break;
                default:
                    break;
            }
            return x.Name.CompareTo(y.Name);
        }
    }
}
