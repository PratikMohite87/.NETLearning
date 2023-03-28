using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class APMExample
    {
        public static void Main1()
        {
            var buffer = new byte[100];
            var fs = new FileStream("Sample.txt", FileMode.Open, FileAccess.Read, FileShare.Read, 1024, FileOptions.Asynchronous);

            IAsyncResult result = fs.BeginRead(buffer, 0, buffer.Length, null, null);

            // Do other things...
            Console.WriteLine("Doing other things");

            int numBytes = fs.EndRead(result);
            fs.Close();

            Console.WriteLine("Read {0}  Bytes:", numBytes);
        }
    }
}
