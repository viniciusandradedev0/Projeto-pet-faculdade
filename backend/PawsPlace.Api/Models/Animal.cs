using PawsPlace.Api.Models.Enums;

namespace PawsPlace.Api.Models;

public class Animal
{
    public int Id { get; set; }
    public string Slug { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;
    public string Especie { get; set; } = string.Empty;
    public string Idade { get; set; } = string.Empty;
    public int IdadeMeses { get; set; }
    public string Imagem { get; set; } = string.Empty;
    public string? LinkDetalhes { get; set; }
    public Sexo? Sexo { get; set; }
    public Porte? Porte { get; set; }
    public bool Castrado { get; set; } = false;
    public bool Vacinado { get; set; } = false;
    public string Cidade { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public string? Descricao { get; set; }
    public DateTime DataEntrada { get; set; } = DateTime.UtcNow;

    public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    public ICollection<Favorito> Favoritos { get; set; } = new List<Favorito>();
    public ICollection<AnimalFoto> Fotos { get; set; } = new List<AnimalFoto>();
}
