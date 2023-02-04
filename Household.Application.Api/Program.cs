using Household.Domain.Model.DataInterface;
using Household.Data.Services;
using Household.Data.EntityFramework.Repositories;
using Household.Data.EntityFramework.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISupplementData, SupplementService>();
builder.Services.AddScoped<IDbContext, FinanceDbContext>();
builder.Services.AddScoped<IRepository<SupplementPurchase>, Repository<SupplementPurchase>>();
builder.Services.AddScoped(_ => new FinanceDbContext("Server=(localdb)\\mssqllocaldb;Database=Finance;Trusted_Connection=True;MultipleActiveResultSets=true"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
