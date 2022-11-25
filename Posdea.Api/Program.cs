using Microsoft.Extensions.Configuration;
using Posdea.Infrastructure.Configurations;
using Posdea.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

//application services                                                                                                                                        
builder.Services.AddProjectsConfig(builder.Configuration);
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//initialize database
using (var scope = app.Services.CreateScope())
{
    var initialiser = scope.ServiceProvider.GetRequiredService<ApplicationDBContextInialiser>();
    await initialiser.InitialiseAsync();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseExceptionHandler("/error");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();