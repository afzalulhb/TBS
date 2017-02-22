using System;
using System.ComponentModel.DataAnnotations;

namespace TBS.Domain.DB.Entity
{
  public  class EReading
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PreviousReading { get; set; }
        public int CurrentReading { get; set; }
        public EMeter EMeter { get; set; }
    }
}
