using Microsoft.EntityFrameworkCore;
using Models;
using System;
namespace EF
{
   public static class DatabaseEFDbContextOptions
   {
      static DbContextOptionsBuilder<DatabaseEF> OptionsBuilder =
         new DbContextOptionsBuilder<DatabaseEF>();
      static DatabaseEFDbContextOptions()
      {
         OptionsBuilder.UseMySql
         (
            MysqlConnnectionString.Value,
            new MySqlServerVersion(new Version(8, 0, 40))
         );
      }
      public static DbContextOptions<DatabaseEF> Value
      {
         get
         {
            return OptionsBuilder.Options;
         }
      }
   }
}
