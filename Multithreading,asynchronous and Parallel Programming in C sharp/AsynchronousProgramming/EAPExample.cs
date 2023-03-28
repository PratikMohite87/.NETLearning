using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class EAPExample
    {
        /*
         * We start an async method that will trigger a Completed event when the task is completed, 
         * making the result available to our application.
         */

        private static void Main2()
        {
            var handler = new ExampleHandler();

            handler.OnTriggerCompleted += (sender, e) =>
            {
                Console.WriteLine($"Triggered at: {DateTime.Now.ToLongTimeString()}");
            };

            handler.Start(3000);

            Console.WriteLine($"Start waiting at {DateTime.Now.ToLongTimeString()}");
            Console.WriteLine($"Processing...");
            Console.ReadLine();
        }
    }

    public class ExampleHandler
    {
        public event EventHandler OnTriggerCompleted;

        public void Start(int timeout)
        {
            var timer = new Timer(new TimerCallback((state) =>
            {
                OnTriggerCompleted?.Invoke(null, null);
            }));

            timer.Change(timeout, 0);
        }
    }
}
