using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public partial class Class1
    {
        public double Cost { set; get; }

        partial void GetSales()
        {
            Console.WriteLine("this from partial method");
        }
    }
}
