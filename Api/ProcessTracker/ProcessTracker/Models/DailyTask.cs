namespace ProcessTracker.Models
{
    public class DailyTask
    {
        //PK
        public int Id { get; set; }
        //Foreign key to User
        public Guid UserId { get; set; }
        public User User { get; set; }

        public string TaskName { get; set; } = "";
        public string? TaskNote { get; set; } = "";
        public DateOnly TaskDueDate { get; set; }
        public bool IsCompleted { get; set; }
        public byte Priority { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime CompletedAt { get; set; }


    }
}
