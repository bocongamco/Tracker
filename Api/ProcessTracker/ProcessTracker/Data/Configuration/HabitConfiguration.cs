using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProcessTracker.Models;

namespace ProcessTracker.Data.Configuration
{
    public class HabitConfiguration : IEntityTypeConfiguration<Habits>
    {
        public void Configure(EntityTypeBuilder<Habits> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.HabitName).IsRequired().HasMaxLength(150);
            b.Property(x => x.HabitFrequency).IsRequired().HasMaxLength(100);
            b.Property(x => x.TargetCount).HasDefaultValue(1);

            b.HasMany(h => h.HabitLogs)
                .WithOne(l => l.Habits)
                .HasForeignKey(l => l.HabitId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
    }
}
