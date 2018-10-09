using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Gear : OrderDecorator
    {
        public Gear(IOrder newOrder) : base(newOrder)
        {

            Console.WriteLine("Adding Gear");
        }

        public new string GetOrder()
        {
            return tempOrder.GetOrder() + " Gear";
        }

        public override decimal Price
        {
            get { return tempOrder.Price + 203.00m; }
        }

    }
}
