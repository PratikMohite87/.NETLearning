using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public partial class Class1
    {
        public int ProductId { set; get; }

        // Partial Method declared in one class.
        // Its private by default & return type is allways void.
        partial void GetSales();
    }
}
