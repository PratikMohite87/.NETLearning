using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class ProductExtensions
    {
        public static double GetDiscount(this Product product)
        {
            return product.DiscountPercentage*100;
        }
    }
}
