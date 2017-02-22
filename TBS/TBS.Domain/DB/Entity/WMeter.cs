using System.ComponentModel.DataAnnotations;

namespace TBS.Domain.DB.Entity
{
    public class WMeter
    {
        [Key]
        public int Id { get; set; }
        public string MeterNumber { get; set; }

        public bool IsActive { get; set; }
    }
}