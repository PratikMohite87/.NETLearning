using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ConstructorsOfThreadClass
    {
        static void Main2(string[] args)
        {
            // So basically thread class constructor accepts delegates like ThreadStart or ParameterisedThreadStart.

            #region Various ways using ThreadStart

            Thread thread = new Thread(Method1);

            ThreadStart threadStart = new ThreadStart(Method1);
            Thread thread1 = new Thread(threadStart);

            ThreadStart threadStart1 = Method1;
            Thread thread2 = new Thread(threadStart1);

            ThreadStart threadStart2 = delegate ()
            {
                Console.WriteLine("New Way");
            };
            Thread thread3 = new Thread(threadStart2);

            // All above are one and the same.

            //thread.Start();
            //thread1.Start();
            //thread2.Start();
            //thread3.Start();

            // ThreadStart delegate does not take method with return value.

            //ThreadStart threadStart3 = Method2;
            //Thread thread4 = new(threadStart3);
            //thread4.Start();

            // ThreadStart does not take methods who has parameters.
            //ThreadStart threadStart3 = Method3;

            #endregion

            #region ParameterizedThreadStart

            // ParameterizedThreadStart only except method with parameter of object type and void return type.
            //Thread thread4 = new Thread(Method3);

            Thread thread4 = new Thread(Method4);
            thread4.Start(2);       // parameters ae passed here.

            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Method4);
            Thread thread5 = new Thread(parameterizedThreadStart);

            // Now if I pass string instead of int : then it will give RTE.

            //thread5.Start("This"); // RTE

            // So we need to pass data in type safe Manner.
            
            int max = 10;
            NumberHelper numberHelper = new NumberHelper(max); // Created helperclass which will inly take int (i.e type safe value.)

            ThreadStart threadStart3 = new ThreadStart(numberHelper.Method5);
            Thread thread6 = new Thread(threadStart3);
            thread6.Start();

            #endregion
        }

        static void Method1()
        {
            Console.WriteLine("This is MEthod1");
        }

        static int Method2()
        {
            return 1;
        }

        static void Method3(int a)
        {
            Console.WriteLine(a);
        }

        static void Method4(object? a)
        {
            Console.WriteLine(Convert.ToInt32(a));
        }
    }

    public class NumberHelper
    {
        private int _Number;

        public NumberHelper(int num)
        {
            _Number = num;
        }

        public void Method5()
        {
            Console.WriteLine(_Number);
        }
    }
}
