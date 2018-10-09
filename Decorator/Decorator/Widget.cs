using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Widget : OrderDecorator
    {
        public Widget(IOrder newOrder) : base(newOrder)
        {

            Console.WriteLine("Creating Widget");
        }

        public new string GetOrder()
        {
            return tempOrder.GetOrder() + " Widget";
        }

        public override decimal Price
        {
            get { return tempOrder.Price + 302.00m; }
        }

    }
}
