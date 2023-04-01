using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Salesman : Employee
    {
        public string Region { get; set; }

        public Salesman()
        {
            Region = "Anonymous";
        }

        public Salesman(int id, string name, string location, string region) : base(id,name, location)
        {
            Region = region;
        }

        public long GetSalesOfTheCurrentMonth()
        {
            return 100000;
        }

        public override void GetLifeInssuranceAmount()
        {
            base.GetLifeInssuranceAmount();
            Console.WriteLine(1001);
        }

        public void GetSalesManDetails()
        {
            Console.WriteLine(EmpId+" "+EmpName+" "+Location+" "+Region);
        }
    }
}
