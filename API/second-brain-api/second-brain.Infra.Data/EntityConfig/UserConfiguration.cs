using second_brain.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace second_brain.Infra.Data.EntityConfig
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(u => u.UserId);

            Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(120);

            Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(u => u.Email)
                .IsRequired();

            Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(16);
        }
    }
}
