using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Model
{
    public class PurchaseOrderItemViewModel
    {
        public string ClientEditId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductCostPrice { get; set; }
        public int Quantity { get; set; }


        public string SupplierName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string DeliveryAddress { get; set; }
        public string Ref { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
