using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Data.Model
{
    public class BackOrder
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductCostPrice { get; set; }
        [Required]
        public string Status { get; set; }
        public string  Comments { get; set; }

    }
}
