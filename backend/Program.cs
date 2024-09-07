using Microsoft.EntityFrameworkCore;
using UdemyCloneBackend.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurando o DbContext com PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionando serviços para os controladores
builder.Services.AddControllers();

// Configurando Swagger para documentação da API (opcional, mas útil para testar a API)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware para usar Swagger (opcional)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
