using GRPCDemo;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc();
var app = builder.Build();
app.MapGrpcService<GreeterService>();
app.MapGet("/", () => "Hello World!");
app.Run();