using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Project is a group of files.
// Solution is a group of projects.

namespace CSharpLangBasics
{
    internal class Program
    {
        static void Main(string[] args) 
        // Main() starting point of program execution. M should be capital.
        // void : does not return any thing. I you return integer value it is returned to os.
        //        If you return 0 from Main => program has executed successfully
        //        If you return 1 from Main => there is some error.
        // static : object creation of class is not necessary to call Main method. so clr can call it to start execution
        {
            Console.Write("Hello world");       // after displaying cursor will be on same line
            Console.WriteLine("Hello world");   // after displaying cursor will be on new line.
            Console.Clear();                    // Clears console window
            Console.WriteLine("Hello world Again");

            string name = Console.ReadLine();   // reads user input from console as string only.
            Console.WriteLine(name);

            Console.ReadKey();                  // Hey console wait till user presses any key.

            // Console class provides set of properties & methods to perform I/O operation in Console App.
            // It is a STATIC class, so all members of class are accessible without creating object of console class.
            // it is a part of BCL.
        }
    }
}
