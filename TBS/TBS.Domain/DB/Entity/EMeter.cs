using System.ComponentModel.DataAnnotations;

namespace TBS.Domain.DB.Entity
{
    public class EMeter
    {
        [Key]
        public int Id { get; set; }
        public string MeterNumber { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}