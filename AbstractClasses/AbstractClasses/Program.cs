using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What is Abstraction in programming

            // Process of hiding implementation details of the object’s feature and showing only the essential information of the feature to the user.
            // Abstraction lets you focus more on what an object does rather than how it does.

            // Real-world example of abstraction could be your TV remote.
            // The remote has different functions like on/off, changing the channel, increasing/decreasing volume, etc.
            // You can use these functionalities by just pressing the button.
            // But, the internal mechanism of these functionalities is abstracted from us as those are not essential for us to know.

            // So in bellow example I have create AbsParent abstract class which has Mul() & Div() abstract method.
            // Then created AbsChild class which inherit from AbsParent class, AbsChild class has override Mul() & Div() method which has implementation logic.
            // Now if I try to do F12 on Mul() or Div() then it will take me to abstract method of AbsParent class,
            //      this behaviour itself says "showing what it does and hiding how it does"
            //      as I will not me able to reach the logic written for Mul() or Div() Method.

            AbsParent abs = new AbsChild();
            abs.Mul(1,2);

            #endregion

            #region Abstract Class in C#

            // A class that is declared by using the keyword abstract is called an abstract class.

            // An abstract class is a partially implemented class used for implementing some of the methods of an object
            //      which are common for all next-level subclasses i.e.all child classes and the remaining abstract methods
            //      to be implemented by the child classes.

            // So, it contains both abstract methods and concrete methods(non-abstract methods) including variables,
            //      properties, and indexers.

            // An abstract class cannot be instantiated directly.
            // It’s compulsory to create a subclass or child class from the abstract class in order to provide the
            //      implementation of its abstract methods.

            // We cannot create instance of an abstract class but we can create reference of it.

            #endregion

            #region Abstract Methods in C#

            // A method that does not have a body is called an abstract method.It is declared with the modifier abstract.
            // It contains only a declaration/signature and does not contain the implementation or body or definition of the
            //      method.
            // An abstract function should be terminated with a semicolon.
            // Overriding an abstract method is compulsory.

            #region When to use the Abstract Method in C#?

            // Abstract methods are usually declared where two or more subclasses are expected to fulfill a similar role
            //      in a different manner.

            // You can also do the same thing using an interface also.
            // But if we are using an abstract class means we can provide some common functionality that is going to be
            //      the same for all the child classes and this is not possible using the interface.

            #endregion

            #region Difference B/W Abstract Method & Method Overriding

            // Method re-implementation is optional in Method Overriding.
            // We need to compulsarly re-implement abstract method in child class.

            #endregion

            #endregion

            #region Summary of Abstract Class and Abstract Methods in C#

            // A method that does not have a body is called an abstract method and the class that is declared by using the
            //      keyword abstract is called an abstract class. If a class contains an abstract method, then it must
            //      be declared as abstract.

            // An abstract class can contain both abstract and non-abstract methods.
            // If a child class of an abstract class wants to consume any non-abstract methods of its parent,
            //      should implement all abstract methods of its parent.

            // An abstract class is never usable to itself because we cannot create the object of an abstract class.
            // The members of an abstract class can be consumed only by the child class of the abstract class.

            #endregion
        }
    }
}
