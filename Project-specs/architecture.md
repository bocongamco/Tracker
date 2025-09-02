# Architecture

## Stack
- **Frontend:** Angular 17+ (standalone, SSR ready), SCSS
- **Backend:** .NET 8 Minimal API
- **DB:** EF Core + SQLite (dev), can swap to SQL Server in prod
- **Dev proxy:** Angular `/api` → .NET (avoids CORS)

## Repo Layout
```
FizzBuzz/
├── Api/ # .NET 8 Web API
├── Frontend/ # Angular app
├── Project-specs/ # Project documentation
```

## Environments
- **Dev:** `ng serve --proxy-config proxy.conf.json` + VS run API
- **Prod options:**
  1) Serve Angular static build (Nginx/Azure SWA) + host API separately
  2) Copy Angular build into API `wwwroot` and serve from .NET
  3) Two containers via docker-compose / k8s

## API Surface (MVP, high level)
- `GET /api/dashboard/summary?date=YYYY-MM-DD`
- **Tasks:** `GET/POST /api/tasks`, `PUT /api/tasks/{id}/complete`
- **Habits:** `GET/POST /api/habits`, `GET/POST /api/habits/{id}/logs`
- **Gym:** `GET/POST /api/exercises`, `POST /api/sessions`, `POST /api/sessions/{id}/sets`, `GET /api/sessions?start&end`

## Security
- Local dev: single user or stub; later add JWT auth