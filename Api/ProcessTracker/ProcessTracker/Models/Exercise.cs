namespace ProcessTracker.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string ExerciseName { get; set; } = "";
        public string DefaultUnit { get; set; } = "kg";
        public bool IsBodyWeight { get; set; } = false;

        public IColeect<WorkoutSets> WorkoutSets { get; set; } = [];
    }
}
