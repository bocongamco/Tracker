namespace ProcessTracker.Models
{
    public class Habits
    {
        public int Id { get; set; }
        //Foreign key to User
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public string HabitName { get; set; } = "";
        public string? HabitNote { get; set; } = "";
        public string HabitFrequency { get; set; } = "";
        public int TargetCount { get; set; } = 1;
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<HabitLogs> HabitLogs { get; set; } = [];
    }
}
