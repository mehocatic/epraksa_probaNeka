using ePraksa.Infrastructure.Database;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// EF DbContext
builder.Services.AddAppDbContext(builder.Configuration);

// MediatR
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(ePraksa.Application.Abstractions.IAppDbContext).Assembly);
});

// Controllers + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var seeder = scope.ServiceProvider.GetRequiredService<DevSeeder>();
    await seeder.Seed();
}

// ✅ Enable Swagger ALWAYS
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ePraksa API v1");
    c.RoutePrefix = string.Empty; // so swagger opens at https://localhost:7058/
});


// Optional: redirect HTTP => HTTPS
app.UseHttpsRedirection();

app.MapControllers();

app.Run();
