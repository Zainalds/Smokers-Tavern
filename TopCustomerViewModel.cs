using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Model
{
    public class TopCustomerViewModel
    {
        public string CustomerName { get; set; }
        public string CustomerEmailAddress { get; set; }
        public string CustomerContactNumber { get; set; }
        public int OrderCount { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal OrderAmount { get; set; }
    }
}
