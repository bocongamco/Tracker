# Product Spec

## Core Jobs To Be Done
- *As a user, I want to list what I must do today and mark it done.*
- *As a user, I want to tick daily habits and see streaks.*
- *As a user, I want to log gym sessions (exercise, set, weight, reps) and see weekly volume.*

## Features
### Must (MVP)
- Auth 
- Today’s Tasks: create/complete, due date = today
- Habits: create, per-day check-ins, streak calc
- Gym: exercises reference, sessions, sets (weight×reps)
- Dashboard: today completion %, habit streaks, 7-day training volume

### Should (near future)
- Recurring tasks; carry-over unfinished tasks
- Workout templates; targets (e.g., 3 sessions/week)
- Tags & filters; CSV export

### Could (later)
- Reminders/notifications (email/PWA)
- PR tracking & est. 1RM; social share weekly report

## User Stories (sample, MVP)
- **Tasks**
  - Given I create a task with title and today’s date, when I tick complete, then it’s counted in today’s completion %.
- **Habits**
  - Given I create a habit with daily schedule, when I log it for today, then my streak increases if I meet target count.
- **Gym**
  - Given I start a session, when I add sets for Bench Press (80kg × 5 reps), then weekly chest volume reflects that set.

## Acceptance Criteria (MVP)
- Dashboard shows **Tasks Done %**, **habit streak lengths**, and **last 7 days training volume** per muscle.
- I can add/edit/delete tasks, habits, exercises; log habit for a day; add sets to a session.
