using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Student : PersonAbstractDemo
    {
        public override string GetName()
        {
            return base.Name;
        }
    }
}
