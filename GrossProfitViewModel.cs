using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Model
{
    public class GrossProfitViewModel
    {
        public string ProductName { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal GrossProfit { get; set; }
        public int totalPurchases { get; set; }
        public int QuantityOnHand { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal totalSellingPrice { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal totalCostPrice { get; set; }
    }
}
