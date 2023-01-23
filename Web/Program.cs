using LogicLibrary;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Factorial of 5 = " + FactorialService.Factorial(5));

app.Run();
