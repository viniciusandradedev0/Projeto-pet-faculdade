using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PawsPlace.Api.Data;
using PawsPlace.Api.DTOs;
using PawsPlace.Api.DTOs.Animais;
using PawsPlace.Api.Models.Enums;

namespace PawsPlace.Api.Controllers;

[ApiController]
[Route("api/animais")]
public class AnimaisController(AppDbContext db) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> ListarAnimais(
        [FromQuery] int pagina = 1,
        [FromQuery] int tamanhoPagina = 12,
        [FromQuery] string? especie = null,
        [FromQuery] string? sexo = null,
        [FromQuery] string? porte = null,
        [FromQuery] bool? castrado = null,
        [FromQuery] bool? vacinado = null,
        [FromQuery] string? estado = null,
        [FromQuery] string? q = null)
    {
        if (pagina < 1)
            return BadRequest(new { mensagem = "O número da página deve ser maior ou igual a 1." });

        if (tamanhoPagina < 1 || tamanhoPagina > 50)
            return BadRequest(new { mensagem = "O tamanho da página deve estar entre 1 e 50." });

        var query = db.Animais.AsQueryable();

        if (!string.IsNullOrWhiteSpace(especie))
            query = query.Where(a => a.Especie == especie.ToLowerInvariant());

        if (!string.IsNullOrWhiteSpace(sexo) && Enum.TryParse<Sexo>(sexo, ignoreCase: true, out var sexoEnum))
            query = query.Where(a => a.Sexo == sexoEnum);

        if (!string.IsNullOrWhiteSpace(porte) && Enum.TryParse<Porte>(porte, ignoreCase: true, out var porteEnum))
            query = query.Where(a => a.Porte == porteEnum);

        if (castrado.HasValue)
            query = query.Where(a => a.Castrado == castrado.Value);

        if (vacinado.HasValue)
            query = query.Where(a => a.Vacinado == vacinado.Value);

        if (!string.IsNullOrWhiteSpace(estado))
            query = query.Where(a => a.Estado == estado.ToUpperInvariant());

        if (!string.IsNullOrWhiteSpace(q))
            query = query.Where(a => a.Nome.ToLower().Contains(q.ToLower()));

        query = query.OrderBy(a => a.Especie).ThenBy(a => a.Nome);

        var totalItens = await query.CountAsync();
        var totalPaginas = (int)Math.Ceiling(totalItens / (double)tamanhoPagina);

        var itens = await query
            .Skip((pagina - 1) * tamanhoPagina)
            .Take(tamanhoPagina)
            .Select(a => AnimalResponseDto.FromModel(a))
            .ToListAsync();

        var resultado = new PaginadoDto<AnimalResponseDto>
        {
            Itens         = itens,
            Pagina        = pagina,
            TamanhoPagina = tamanhoPagina,
            TotalItens    = totalItens,
            TotalPaginas  = totalPaginas,
            TemProxima    = pagina < totalPaginas,
            TemAnterior   = pagina > 1
        };

        return Ok(resultado);
    }

    [HttpGet("{slug}")]
    public async Task<IActionResult> ObterAnimal(string slug)
    {
        var slugNormalizado = slug.ToLowerInvariant();

        var animal = await db.Animais
            .Include(a => a.Fotos)
            .FirstOrDefaultAsync(a => a.Slug == slugNormalizado);

        if (animal is null)
            return NotFound(new { mensagem = "Animal não encontrado." });

        return Ok(AnimalDetalheResponseDto.FromModel(animal));
    }
}
