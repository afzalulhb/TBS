using System;
using System.ComponentModel.DataAnnotations;

namespace TBS.Domain.DB.Entity
{
  public  class Tenant
    {
        [Key]
        public int Id { get; set; }
        public Flat Flat { get; set; }
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string PAddress { get; set; }
        public string Telephone { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
    }
}
