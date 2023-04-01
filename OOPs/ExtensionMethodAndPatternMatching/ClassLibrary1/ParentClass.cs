using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ParentClass
    {
        public int X { get; set; }
    }
    public class ChildClass : ParentClass
    {
        public int Y { get; set; }
    }
}
