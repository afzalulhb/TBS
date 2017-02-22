using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TBS.Domain.DB.Entity
{
  public  class Flat
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public decimal Rent { get; set; }

        public List<EMeter> EMeters { get; set; }
        public List<WMeter> WMeters { get; set; }
        public List<UtilityOption> UtilityOptions { get; set; }
    }
}
