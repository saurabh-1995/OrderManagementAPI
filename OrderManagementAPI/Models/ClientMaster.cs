using System;
using System.Collections.Generic;

namespace OrderManagementAPI.Models
{
    public partial class ClientMaster
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public long? Phone { get; set; }
        public string Address { get; set; }
        public int? ItemId { get; set; }

        public ItemMaster Item { get; set; }
    }
}
