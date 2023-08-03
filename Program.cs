using CriarAPI.WebApi.Contexts;
using CriarAPI.WebApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

builder.Services.AddScoped<CriarAPIContext,
CriarAPIContext>();
builder.Services.AddControllers();
builder.Services.AddTransient<LivroRepository,
LivroRepository>();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
endpoints.MapControllers();
});

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