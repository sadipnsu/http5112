using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandyStore.Models
{
    public class Order
    {
        public decimal OrderTotal { get; set; }
        public string OrderName { get; set; }
        public string CandySize { get; set; }


    }
}