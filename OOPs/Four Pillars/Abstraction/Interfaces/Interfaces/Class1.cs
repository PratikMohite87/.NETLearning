using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Class1 : Interface1, Interface2 // allowing multipe inheritance
    {
        public void Div(int i, int j)
        {
            Console.WriteLine(i / j);
        }

        public void Mul(int i, int j)
        {
            Console.WriteLine(i * j);
        }

        #region Implementing members explicitly

        void Interface2.Add(int i, int j)
        {
            Console.WriteLine(i + j);
        }

        void Interface2.Subtract(int i, int j)
        {
            Console.WriteLine(i - j);
        }

        #endregion
    }
}
