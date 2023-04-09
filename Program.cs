
var builder = WebApplication.CreateBuilder(args);




var app = builder.Build();
app.Urls.Add("http://localhost:5000");

// Middlewares


app.MapGet("/", () => "Hello World!");
app.MapGet("/ucas", () => "ucas.edu.ps");
app.MapGet("/coddict", () => new
{
    Name = "City",
    Url = "https://coddict.co",
    Started = 4000
});

app.MapPost("/students", () => "Student Created!");

app.Run();

