using Microsoft.EntityFrameworkCore;
using MoblieStore.Models;

namespace MobileStore.Models
{
    #region Mobile Context
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }
        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
    #endregion
}
