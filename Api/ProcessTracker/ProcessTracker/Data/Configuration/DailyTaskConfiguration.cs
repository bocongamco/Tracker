using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProcessTracker.Models;

namespace ProcessTracker.Data.Configuration
{
    public class DailyTaskConfiguration : IEntityTypeConfiguration<DailyTask>
    {
        public void Configure(EntityTypeBuilder<DailyTask> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.TaskName).IsRequired().HasMaxLength(200);
            b.Property(x => x.TaskNote).HasMaxLength(2000);

            
            b.Property(x => x.TaskDueDate).HasColumnType("date");

            b.Property(x => x.Priority).HasDefaultValue((byte)2);
            b.HasIndex(x => new { x.UserId, x.TaskDueDate }); 
        }
    }
}
