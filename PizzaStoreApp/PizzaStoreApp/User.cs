using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreApp.Library
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Location DefaultLocation { get; set; }
        public Order SuggestedOrder { get; set; }

    }
}
