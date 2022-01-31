using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryDelivery.Models
{
    public class Customer
    {
        public int CustomerID {get; set;}  // Primary Key
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Address {get; set;}
        public int PhoneNumber {get; set;}
        public string Email {get; set;}
        public int CreditCard {get; set;}
        public List<OrderDelivery> OrderDeliveries {get; set;} // Navigation Property
    }
}