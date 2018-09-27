using System;
using System.Collections.Generic;

namespace OrderManagementAPI.Models
{
    public partial class OrderMaster
    {
        public int OrderId { get; set; }
        public string ClientName { get; set; }
        public string ItemName { get; set; }
        public int? Quantity { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
