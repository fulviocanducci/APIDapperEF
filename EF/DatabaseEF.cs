using EF.Mappings;
using Microsoft.EntityFrameworkCore;
using Models;
namespace EF
{
   public class DatabaseEF : DbContext
   {
      public DatabaseEF(DbContextOptions<DatabaseEF> options) : base(options) { }

      public DbSet<People> People { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.ApplyConfiguration(new PeopleMapping());
      }
   }
}
