# ASP.NET-LibraryAPI

ASP.NET-LibraryAPI is a project that was created as an introductory task for the company Modsen.

System Requirements: .NET 8 or later

### Run

```
git clone https://github.com/denis-pptx/ASP.NET-LibraryAPI.git
```

```
cd ASP.NET-LibraryAPI/Library/Library.API
```

```
dotnet run --launch-profile https
```

```
https://localhost:7127/swagger/index.html
```

### Usage
1. /api/login - get JWT token. Default user is { "login": "admin", "password": "admin" }
2. Insert token to Authorize input as "Bearer <token\>"
3. Use API. All controllers except of AuthController require authorization.
