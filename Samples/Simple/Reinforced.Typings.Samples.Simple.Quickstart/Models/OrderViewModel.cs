using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reinforced.Typings.Samples.Simple.Quickstart.Models {

    using Reinforced.Typings.Attributes;

    public class OrderViewModel {
        public string Address { get; set; }
        public string ClientName { get; set; }
        public bool IsPaid { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double Subtotal { get; set; }
    }
}