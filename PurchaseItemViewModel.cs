using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Model
{
    public class PurchaseItemViewModel
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public decimal ProductCostPrice { get; set; }
    }
}
