﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Data.Model
{
    public class PurchaseItem
    {
        [Key]
        public int Id { get; set; }
        public string ClientId { get; set; }
        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        //[Display(Name ="Product")]
        //[ForeignKey("Product")]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductCostPrice { get; set; }
        public string Received { get; set; }
        //public virtual Product Product { get; set; }
    }
}
