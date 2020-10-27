﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Model
{
    public class PuchaseOrderItemsViewModel
    {

        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal LinePrice { get; set; }
        public string OrderDeliveryAddress { get; set; }
        public string OrderReferenceNumber { get; set; }
        public string OrderContactPerson { get; set; }
        public string OrderContactNumber { get; set; }
        public DateTime PrintTime { get; set; }

    }
}
