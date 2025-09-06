using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProcessTracker.Models;

namespace ProcessTracker.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> b)
        {
            b.HasKey(b => b.Id);
            b.Property(b => b.UserName)
                .IsRequired()
                .HasMaxLength(100);
            b.Property(b =>b.PasswordHash)
                .IsRequired()
                .HasMaxLength(500);
            b.Property(b => b.Email)
                .IsRequired()
                .HasMaxLength(255);


            b.HasMany(u => u.DailyTasks)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            b.HasMany(u => u.Habits)
                .WithOne(h=>h.User)
                .HasForeignKey(h => h.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            b.HasMany(u => u.WorkoutSessions)
                .WithOne(ws => ws.User)
                .HasForeignKey(ws => ws.UserId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
