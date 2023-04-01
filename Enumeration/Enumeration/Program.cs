// Enumeration : it is a collection of constants.
//               is used to specify list of options allowed to be stored in a field/variable.

// Goal : Use enum if you don`t want to allow other developers to assign other value into a field/variable, other than 
//        the list of values specified in the enumeration.

// For every constant in enum there is integer value behind it, default start from 0.
// We can explicitly provide value.
// We can also store datatype of enum.

using Enumeration;

Person person = new Person();
person.PersonName = "Pratik";
person.Email = "xyz";
person.AgeGroup = AgeGroupEnum.Teenager;
Console.WriteLine(person.PersonName + " " + person.Email + " " + person.AgeGroup);
