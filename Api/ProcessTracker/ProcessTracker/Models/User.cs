namespace ProcessTracker.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = "";
        public string? PasswordHash { get; set; } = "";
        public string Email { get; set; }
        public string Role { get; set; }

        //Navigate to DailyTasks, Habits, User Can have multiple DailyTasks, Habits
        public ICollection<DailyTask> DailyTasks { get; set; } = [];
        public ICollection<Habits> Habits { get; set; } = [];   
        public ICollection<WorkoutSession> WorkoutSessions { get; set; } = [];

    }
}
