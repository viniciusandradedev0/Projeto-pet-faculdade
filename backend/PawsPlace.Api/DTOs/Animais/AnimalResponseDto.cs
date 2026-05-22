using PawsPlace.Api.Models;
using PawsPlace.Api.Models.Enums;

namespace PawsPlace.Api.DTOs.Animais;

// DTO para listagem em catálogo — inclui campos de filtro mas não a galeria completa
public record AnimalResponseDto(
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
    string? Descricao)
{
    public static AnimalResponseDto FromModel(Animal a) => new(
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
        a.Descricao);
}
