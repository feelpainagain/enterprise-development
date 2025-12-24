using Bogus;
using BikeRentalPoint.Generation.GrpcServer.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
builder.Services.AddSingleton(new Faker("ru"));
builder.Services.AddSingleton<GenerationServiceImpl>();

var app = builder.Build();

app.MapGrpcService<GenerationServiceImpl>();

app.Run();
