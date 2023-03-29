using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Process of hiding implementation details of the object’s feature and showing only the essential information of the feature to the user.
            // Abstraction lets you focus more on what an object does rather than how it does.

            // Real-world example of abstraction could be your TV remote.
            // The remote has different functions like on/off, changing the channel, increasing/decreasing volume, etc.
            // You can use these functionalities by just pressing the button.
            // But, the internal mechanism of these functionalities is abstracted from us as those are not essential for us to know.

            // So in bellow example I have create PersonAbstractDemo abstract class which has GetName abstract method.
            // Then created Student class which inherit from PersonAbstractDemo class, student class has override GetName method which has implementation logic for get Name.
            // Now if I try to do F12 on GetName() then it will take me to abstract method of PersonAbstractDemo class,
            //      this behaviour itself says "showing what it does and hiding how it does"
            //      as I will not me able to reach the logic written for GetName Method.

            PersonAbstractDemo demo = new Student();
            demo.GetName();

            // Its is a parent class for which we can`t create object but we can create child class.
            // Main intention is to provide common set of fields & methods to all its child classes of specific group.
            // It can inherit from other class or interface.

            // Abstract Method : Are declared in parent class with "abstract keyword"; implemented in child classes with "override" keyword.
            //                   It is used when parent class don`t want to provide the definition of member,
            //                      but it wants to let child classes to implement method.
        }
    }
}
