using System;
using System.ComponentModel.DataAnnotations;

namespace TBS.Domain.DB.Entity
{
   public class WReading
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PreviousReading { get; set; }
        public int CurrentReading { get; set; }
        public WMeter WMeter { get; set; }
    }
}
