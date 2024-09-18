# bookify api

API for bookify project

## tools used

dotnet core 7.0 [https://dotnet.microsoft.com/download/dotnet/7.0](https://dotnet.microsoft.com/download/dotnet/7.0)

visual studio community 2022 [https://visualstudio.microsoft.com/](https://visualstudio.microsoft.com/)

Entity framework core 7.0 [https://docs.microsoft.com/en-us/ef/core/](https://docs.microsoft.com/en-us/ef/core/)

## how to run

1. Clone the repository
2. Open the solution in visual studio
3. Run the project
4. The project will be running on `https://localhost:5001` and `http://localhost:5000` by default

## add the database use entity framework core tools

database is used postgreSQL database

1. Open the terminal
2. Run the following command to add the database

```bash
dotnet ef database update
```

## how to use

1. Open the browser
2. Go to `https://localhost:5001/swagger/index.html` or `http://localhost:5000/swagger/index.html`
3. You will see the swagger documentation
4. You can test the API from the swagger documentation
5. You can also use postman to test the
6. You can also use the API from the frontend project

