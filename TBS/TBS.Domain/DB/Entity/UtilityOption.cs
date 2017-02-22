using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TBS.Domain.DB.Entity
{
    public class UtilityOption
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public bool IsActive { get; set; }
        public List<Flat> Flats { get; set; }
    }
}