using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Model
{
    public class TopSellingProductViewModel
    {

        public int Id { get; set; }
        public string ProductPurchaseName { get; set; }
        public int ProductPurchaseQuantity { get; set; }
        public decimal ProductPurchaseTotal { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ProductPurchaseDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal GrandTotal { get; set; }


    }
}
