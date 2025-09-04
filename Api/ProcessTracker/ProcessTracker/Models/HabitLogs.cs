namespace ProcessTracker.Models
{
    public class HabitLogs
    {
        public int Id { get; set; }
        //Foreign key to Habits
        public int HabitId { get; set; }
        public Habits Habits { get; set; } = null!;
        public DateOnly LogDate { get; set; }
        public int LogCount { get; set; }
    }
}
