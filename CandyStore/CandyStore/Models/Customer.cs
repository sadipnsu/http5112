using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandyStore.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
    }
}