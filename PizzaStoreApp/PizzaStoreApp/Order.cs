using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreApp
{
    public class Order
    {
        public DateTime OrderTime { get; set; }
        public Location OrderLocation { get; set; }
        public User Buyer { get; set; }
    }
}
