using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asign2
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor();
            var Order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process();

            public class OrderProcessor
        {
            private readonly ShippingCalculator _shippingCalculator;
            public OrderProcessor()
       {
            _shipppingCalculator = new ShippingCalculator();
        }
            public void Process(Order order) {
                if (order.IsShipped)
                    throw new InvalidOperationException("This order is shipped.");

                order.Shipment = new Shipment
                {
                    Cost = _shippingCalculator.CalculatorShipping(order),
                    ShippingDate = DateTime.Today.AddDays(1);

                }
            }
    }

}
    }
}
