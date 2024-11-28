using MediatrUsingExample;
using MediatrUsingExample.Repositories.InMemory;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
services.AddOpenApi();
services.AddSwaggerGen();
services.AddEndpointsApiExplorer();
services.AddControllers();

// register application services
services.AddApplicationServices();

// register infrastructure
services.AddInMemoryRepositories();

var app = builder.Build();
app.UseRouting();
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();