using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public partial class Class1
    {
        public double GetTax()
        {
            double tax = Cost * 10 / 100;
            return tax;
        }

        public void CallPartialMethod()
        {
            GetSales();
        }
    }
}
