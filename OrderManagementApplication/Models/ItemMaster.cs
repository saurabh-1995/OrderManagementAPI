using System;
using System.Collections.Generic;

namespace OrderManagementApplication.Models
{
    public partial class ItemMaster
    {
        public ItemMaster()
        {
            ClientMaster = new HashSet<ClientMaster>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public int ItemQuantity { get; set; }

        public virtual ICollection<ClientMaster> ClientMaster { get; set; }
    }
}
