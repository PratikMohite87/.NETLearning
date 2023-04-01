using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    public enum AgeGroupEnum
    {
        Child, //bydefault //0
        Teenager, //1
        Adult = 100, //2
        Senior // 3
    }

    public enum AgeGroupEnum2 : short
    {
        todler,
        modler,
        bodler
    }
}
