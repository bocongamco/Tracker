using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProcessTracker.Models;

namespace ProcessTracker.Data.Configuration
{
    public class DailyTaskConfiguration : IEntityTypeConfiguration<DailyTask>
    {
        public void Configure(EntityTypeBuilder<DailyTask> b)
        {
            b.HasKey(b => b.Id);
        }
    }
}
