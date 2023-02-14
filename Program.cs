using blazorapi;
using blazorapi.Interfaces;
using blazorapi.Schemas.Types;
using blazorapi.Service;
using gqlServer.Data;
using gqlServer.Schemas;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<ICake,CakeService>();
builder.Services.AddGraphQLServer()
    .AddFiltering()
    .AddQueryType<Query>();
    // .AddQueryType(q => q.Name("Query"));
    // .AddType<CakeQueryResolver>();
// builder.Services.AddDbContext<CakeContext>(o => o.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy("_myAllowSpecificOrigins",
                      policy  =>
                      {
                          policy.WithOrigins("*")
                          .AllowAnyHeader()
                            .AllowAnyMethod();
                      });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(MyAllowSpecificOrigins);

app.MapControllers();
app.MapGraphQL("/");

app.Run();
