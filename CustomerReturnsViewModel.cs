using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Model
{
    public class CustomerReturnsViewModel
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        [Required]
        public string Item { get; set; }
        [Required]
        public string Reason { get; set; }
        public string Status { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string PickUpDate { get; set; }
    }
}
