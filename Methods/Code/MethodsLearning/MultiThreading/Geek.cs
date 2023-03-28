using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Geek
    {
        public void Method1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Method-1: " + i);
                //Thread.Sleep(5000);
            }
        }

        public void Method2()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("Method-2: " + i);
        }

        public void Method3(object i)
        {
            Console.WriteLine(i.ToString());
        }
    }
}
