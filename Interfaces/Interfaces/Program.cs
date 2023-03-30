using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // It is a pure abstract class that contains set of abstract method which must be implemented by the child classes.

            // The Interface in C# is a Fully Un-Implemented Class used for declaring a set of operations/methods of an object.
            // So, we can define an interface as a pure abstract class which allows us to define only abstract methods.
            // The abstract method means a method without a body or implementation.

            // It is used to achieve multiple inheritances which can’t be achieved by class.
            // It is used to achieve full abstraction because it cannot have a method body.

            // Interface cannot be inherit from other classes it can inherit from interface.

            // Every member of an interface should be implemented under the child class without fail (mandatory),
            //  but while implementing we don’t require to use the override modifier just like we have done
            //  in the case of an abstract class.

            // Interface can only have Non-Static Events, Abstract Methods, Non-Static autoimplemented properties.
            // An interface can contain Abstract methods, Properties, Indexes, Events.
            // An interface cannot contain Non-abstract functions, Data fields, Constructors, Destructors

            // Access modifiers for all methods public you cannot change it.
            // All methods are public and abstract by default.

            // Class: Contains only the Non-Abstract Methods (Methods with Method Body).
            // Abstract Class: Contains both Non - Abstract Methods(Methods with Method Body) and Abstract Methods(Methods without Method Body).
            // Interface: Contain only Abstract Methods(Methods without Method Body).
        }
    }
}
