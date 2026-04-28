using Employment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Employment.Infra.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // اسم الجدول
            builder.ToTable("Users");

            // المفتاح الأساسي
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id)
                   .ValueGeneratedOnAdd();
            // إعدادات الحقول
            builder.Property(u => u.FirstName)
                   .HasMaxLength(100)
                   .IsRequired(false); // لأنك وضعت ? في الموديل

            builder.Property(u => u.LastName)
                   .HasMaxLength(100)
                   .IsRequired(false);

            //// يمكنك إضافة بيانات تجريبية (Seed Data) هنا إذا أردت
            //builder.HasData(
            //    new User { Id = 1, FirstName = "Test", LastName = "User" }
            //);
        }
    }
}
