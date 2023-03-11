using Microsoft.EntityFrameworkCore;
using Repository_Pattern.Data;
using Repository_Pattern.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IPedidoRepository, PedidoRepository>();

string ConnectionString = builder.Configuration.GetConnectionString("Root");
builder.Services.AddDbContext<DataContext>(options => options.UseMySql(ServerVersion.AutoDetect(ConnectionString)));

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
