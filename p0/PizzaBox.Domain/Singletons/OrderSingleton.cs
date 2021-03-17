using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Domain.Singletons
{
    public class OrderSingleton
    {
        private static OrderSingleton _orderSingleton;
        public static List<Order> Orders { get; set; } // print job

        public static OrderSingleton Instance
        {
            get
            {
                if (_orderSingleton == null)
                {
                    _orderSingleton = new OrderSingleton(); // printer
                }

                return _orderSingleton;
            }
        }

        private OrderSingleton()
        {
            Orders = new List<Order>();
        }

        public void Serialize(Order o)
        {
            var fs = new FileStorage();

            Orders = Deserialize();
            Orders.Add(o);
            fs.WriteToXml<Order>(Orders);
        }

        public List<Order> Deserialize()
        {
            var fs = new FileStorage();
            List<Order> orders = fs.ReadFromXml<Order>().ToList();

            return orders;
        }
    }
}