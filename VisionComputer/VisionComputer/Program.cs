using VisionComputer;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

Console.WriteLine("Starting camera test...");
var cam = new Cam();
cam.TestConnection();