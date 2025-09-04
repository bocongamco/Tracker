namespace ProcessTracker.Models
{
    public class WorkoutSets
    {
        public int Id { get; set; }

        //Foreign key to Exercise,WorkoutSessions
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; } = null!;
        public int WorkoutSessionId { get; set; }
        public WorkoutSession WorkoutSession { get; set; } = null!;
        
        public int SetNumber { get; set; }
        public int Repetitions { get; set; }
        public decimal? Weight { get; set; }
        public decimal? RPE { get; set; } // Rate of Perceived Exertion (How hard the exercise is)
        public decimal? RIR { get; set; } // Reps In Reserve.(How closed to failure)

    }
}
