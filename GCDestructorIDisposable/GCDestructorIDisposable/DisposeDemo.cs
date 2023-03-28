using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDestructorIDisposable
{
    internal class DisposeDemo : IDisposable
    {
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //Write Code Here to Destroy the Managed Resources
                    Console.WriteLine("Managed Resources Destroyed by Dispose Method");
                }
                //Write Code Here to Destroy the Umanaged Resources
                Console.WriteLine("Unmanaged Resources Destroyed by Dispose Method");
                disposedValue = true;
            }
            else
            {
                Console.WriteLine("Resources are Already Destroyed by Dispose Method");
            }
        }
        ~DisposeDemo()
        {
            //Write Code here to Destroy the Object
            Console.WriteLine("Request Comes to Destructor to Destroy the Resources");
            Dispose(false);
        }
        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            //Write Code here to Destroy the Object
            Console.WriteLine("Request Comes to Dispose Method to Destroy the Resources");
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
