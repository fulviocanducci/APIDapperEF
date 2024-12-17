using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace EF.Mappings
{
   public class PeopleMapping : IEntityTypeConfiguration<People>
   {
      public void Configure(EntityTypeBuilder<People> builder)
      {
         builder.ToTable("people");
         builder.Property(c => c.Id).HasColumnName("id").UseMySqlIdentityColumn();
         builder.Property(c => c.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
         builder.Property(c => c.CreatedAt).HasColumnName("created_at").IsRequired();
         builder.Property(c => c.UpdatedAt).HasColumnName("updated_at").HasDefaultValue(null);
         builder.Property(c => c.Status).HasColumnName("status").IsRequired();
      }
   }
}
