using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Model
{
    public class TopSellers
    {
        public string ProductPurchaseName { get; set; }
        public int ProductQuantity { get; set; }
        public string ImageUrl { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ProductPrice { get; set; }
    }
}
