using second_brain.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace second_brain.Infra.Data.EntityConfig
{
    public class ReminderConfiguration : EntityTypeConfiguration<Reminder>
    {
        public ReminderConfiguration()
        {
            HasKey(r => r.ReminderId);

            Property(r => r.Title)
                .IsRequired()
                .HasMaxLength(150);

            Property(r => r.Description)
                .IsRequired()
                .HasMaxLength(340);

            HasRequired(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId);
        }
    }
}
