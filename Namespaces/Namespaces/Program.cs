using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using HR.manager;   //  USING NAMESPACE
using m = HR.manager.Manager;   // Alias
using static System.Console;    // using static

namespace Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Namespace : it is a collection of classes & other types such as interfaces, structures, deletgate types, enumerations.

            //HR.IManager manager = new HR.Manager();
            //FrontOffice.CustomerEnquiry customerEnquiry = new FrontOffice.CustomerEnquiry();

            // Namespace in namespace is called nested namespace.

            //HR.manager.IManager a = new HR.manager.Manager();
            //IManager manager = new Manager();   //  USING NAMESPACE

            // Note : using HR; will not get you manager namespace you have to import it like
            //        using HR.manager;

            // Alias for name space : using aliasname = Namespace;

            //m manager1 = new m();

            // using static.
            // purpose is that you can access all methods of static class in particlar namesapce without using Class name

            WriteLine("using static");
        }
    }
}
