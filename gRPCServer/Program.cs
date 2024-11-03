using GrpcGreeting;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc();

var app = builder.Build();

// Map your gRPC service
app.MapGrpcService<GreetingServiceImpl>();
app.MapGet("/", () => "Hello World!");

// Configure to run with HTTPS (required for gRPC with HTTP/2)
app.Run("https://localhost:5001"); // Use HTTPS for HTTP/2
