using PawsPlace.Api.Models;
using PawsPlace.Api.Models.Enums;

namespace PawsPlace.Api.DTOs.Animais;

// DTO para página de detalhe — inclui a galeria completa de fotos
public record AnimalDetalheResponseDto(
    int Id,
    string Slug,
    string Nome,
    string Especie,
    string Idade,
    int IdadeMeses,
    string Imagem,
    string? LinkDetalhes,
    Sexo? Sexo,
    Porte? Porte,
    bool Castrado,
    bool Vacinado,
    string Cidade,
    string Estado,
    string? Descricao,
    DateTime DataEntrada,
    List<FotoResponseDto> Fotos)
{
    public static AnimalDetalheResponseDto FromModel(Animal a) => new(
        a.Id,
        a.Slug,
        a.Nome,
        a.Especie,
        a.Idade,
        a.IdadeMeses,
        a.Imagem,
        a.LinkDetalhes,
        a.Sexo,
        a.Porte,
        a.Castrado,
        a.Vacinado,
        a.Cidade,
        a.Estado,
        a.Descricao,
        a.DataEntrada,
        a.Fotos.OrderBy(f => f.Ordem)
               .Select(f => new FotoResponseDto(f.Ordem, f.UrlImagem))
               .ToList());
}
