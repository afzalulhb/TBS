using System.ComponentModel.DataAnnotations;

namespace TBS.Domain.DB.Entity
{
   public class WBillingRules
    {

        [Key]
        public int Id { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal Vat { get; set; }
    }
}
