using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrder myOrder = new Gear(new Widget(new Order()));

            Console.WriteLine(myOrder.GetOrder());

            Console.WriteLine(myOrder.Price);

        }
    }
}
