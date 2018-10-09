using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Order : IOrder
    {

        public decimal TotalCost = 0m;

        

        public string GetOrder()
        {
            return "";
        }

        public  decimal Price
        {
            get { return 570.00m; }
        }
    }
    
}
