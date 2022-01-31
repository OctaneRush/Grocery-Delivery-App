using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryDelivery.Models
{
    public class Order
    {
        public int OrderID {get; set;} // Primary Key
        public int PricePaid {get; set;}
        public int CustomerID {get; set;} // Foreign Key
        public Customer Customer {get; set;} // Reference Object
        public List<Item> Items {get; set;} // Navigation Property
        public OrderDelivery OrderDelivery {get; set;} // Reference Object
    }
}