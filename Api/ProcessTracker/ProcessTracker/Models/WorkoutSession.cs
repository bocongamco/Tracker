namespace ProcessTracker.Models
{
    public class WorkoutSession
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public DateTime SessionDate { get; set; }
        public int? DurationInMinutes { get; set; }
        public string? Note { get; set; } = "";

        public ICollection<WorkoutSets> WorkoutSets { get; set; } = [];


    }
}
