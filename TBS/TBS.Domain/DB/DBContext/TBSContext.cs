using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBS.Domain.DB.Entity;

namespace TBS.Domain.DB.DBContext
{
    public class TBSContext:DbContext
    {
        public DbSet<Flat> Flats { get; set; }
        public DbSet<WMeter> WMeters { get; set; }
        public DbSet<WReading> WReadings { get; set; }
        public DbSet<UtilityOption> UtilityOptions { get; set; }
        public DbSet<WBillingRules> WBillingRules { get; set; }
        public DbSet<EMeter> EMeters { get; set; }
        public DbSet<EBillingRules> EBillingRules { get; set; }
        public DbSet<EReading> EReadings { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TmpMonthlyBill> TmpMonthlyBills { get; set; }

    }
}
