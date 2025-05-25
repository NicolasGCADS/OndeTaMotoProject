using OndeTaMotoBusiness;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API OndeT·Moto",
        Version = "v1",
        Description = "DocumentaÁ„o da API OndeT·Moto usando Swagger"
    });
});


builder.Services.AddDbContext<DbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<MotoService>();

builder.Services.AddScoped<UsuarioService>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API OndeT·Moto v1");
        c.RoutePrefix = "swagger";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
