using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// ============================================================
// PARTE 1: SERVIÇOS (injeção de dependência)
// Aqui registramos "o que a aplicação sabe fazer". Nada roda ainda:
// é um catálogo que o ASP.NET consulta quando alguém pede uma dependência
// (ex.: um controller que recebe um service no construtor).
// ============================================================
builder.Services.AddControllers();   // habilita classes Controller
builder.Services.AddOpenApi();       // gera o documento /openapi/v1.json descrevendo os endpoints

var app = builder.Build();

// ============================================================
// PARTE 2: PIPELINE HTTP (middlewares)
// Toda requisição passa por estes "filtros" NA ORDEM em que aparecem,
// até chegar ao controller. A resposta faz o caminho de volta.
// ============================================================
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();           // expõe /openapi/v1.json
    app.MapScalarApiReference(); // tela para testar a API em /scalar
}

app.UseAuthorization();  // verifica [Authorize] (usaremos na Etapa 5)

app.MapControllers();    // liga as rotas ([Route], [HttpGet]...) aos métodos dos controllers

app.Run();
