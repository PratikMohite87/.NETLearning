using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    public delegate void SumOfNumberCallbackDelegate(int sumOfNum);

    internal class ReturnValueUsingCallback
    {
        // Retrieving data from thread using callback method.

        public static void Main3(string[] args)
        {
            int max = 10;

            SumOfNumberCallbackDelegate _callback = new SumOfNumberCallbackDelegate(DisplaySumOfNum);

            NumberHelper2 numberHelper2 = new NumberHelper2(max, _callback);

            ThreadStart threadStart = new ThreadStart(numberHelper2.ShowNumbers);

            Thread thread = new Thread(threadStart);

            thread.Start();

        }

        public static void DisplaySumOfNum(int sum)
        {
            Console.WriteLine("The sum of numbers is : " + sum);
            // return sum;
        }

    }

    public class NumberHelper2
    {
        private int _number;
        SumOfNumberCallbackDelegate _callbackDelegate;

        public NumberHelper2(int num, SumOfNumberCallbackDelegate _delegate)
        {
            _number = num;
            _callbackDelegate = _delegate;
        }

        public void ShowNumbers()
        {
            int sum = 0;

            for (int i = 0; i < _number; i++)
            {
                sum = sum + i;
            }

            if (_callbackDelegate != null)
                _callbackDelegate(sum);
        }
    }
}
