# Data Model (Temporary)
# Noted: Can be changed later as futher development.
## Users
- Id (GUID, PK)
- UserName, Email (unique), PasswordHash?, CreatedAt

## DailyTasks
- Id (PK), UserId (FK)
- Title, Notes?, DueDate (date), IsCompleted (bit), Priority (1..3), Tag?
- CreatedAt, CompletedAt?

## Habits
- Id (PK), UserId (FK)
- Name, Schedule ("daily" or JSON days), TargetCount (int, default 1)
- CreatedAt, IsArchived (bit)

## HabitLogs
- Id (PK), HabitId (FK)
- LogDate (date), Count (int)
- **Unique:** (HabitId, LogDate)

## Exercises (reference)
- Id (PK), Name (unique), DefaultUnit ("kg","lb","bw"), IsBodyweight (bit)

## MuscleGroups (reference)
- Id (PK), Name (unique)

## ExerciseMuscles (join)
- ExerciseId (FK), MuscleGroupId (FK)
- **PK:** (ExerciseId, MuscleGroupId)

## WorkoutSessions
- Id (PK), UserId (FK)
- SessionDate (datetime), DurationMin?, Notes?

## WorkoutSets
- Id (PK), SessionId (FK), ExerciseId (FK)
- SetNumber (int), Weight? (decimal 6,2), Reps (int), RPE?, Tempo?
- **Index:** (SessionId, ExerciseId)
