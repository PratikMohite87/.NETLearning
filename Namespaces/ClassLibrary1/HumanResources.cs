using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    namespace manager
    {
        public interface IManager : IEmployee { }

        public class Manager : IManager { }

    }

    public interface IEmployee { }
   
    public interface IExecutive : IEmployee { }
   
}
