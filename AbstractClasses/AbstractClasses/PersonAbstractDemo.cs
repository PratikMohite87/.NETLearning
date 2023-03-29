using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal abstract class PersonAbstractDemo
    {
        public string Name;
        public string Description;

        public PersonAbstractDemo() { }

        public abstract string GetName();
    }
}
