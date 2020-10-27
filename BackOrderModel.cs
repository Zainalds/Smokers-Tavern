using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Model
{
    public class BackOrderModel
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int ProductQuantity { get; set; }
        [Required]
        public decimal ProductCostPrice { get; set; }
        [Required]
        public string Status { get; set; }
        public string Comments { get; set; }
    }
}
