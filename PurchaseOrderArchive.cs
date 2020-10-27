using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Data.Model
{
    public class PurchaseOrderArchive
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ClientId { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Numbers and special characters are not allowed.")]
        public string ContactPerson { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string DeliveryAddress { get; set; }
        public string Ref { get; set; }
        public DateTime CreateTime { get; set; }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
    }
}
