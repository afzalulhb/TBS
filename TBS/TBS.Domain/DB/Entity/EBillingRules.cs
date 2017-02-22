﻿using System.ComponentModel.DataAnnotations;

namespace TBS.Domain.DB.Entity
{
   public class EBillingRules
    {
        [Key]
        public int Id { get; set; }
        public int From1 { get; set; }
        public int From2 { get; set; }
        public int From3 { get; set; }
        public int From4 { get; set; }
        public int To1 { get; set; }
        public int To2 { get; set; }
        public int To3 { get; set; }
        public int To4 { get; set; }
        public decimal Rate1 { get; set; }
        public decimal Rate2 { get; set; }
        public decimal Rate3 { get; set; }
        public decimal Rate4 { get; set; }
        public decimal DemandCharge { get; set; }
        public decimal MinimumCharge { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal Vat { get; set; }
    }
}
