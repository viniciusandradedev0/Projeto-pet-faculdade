namespace PawsPlace.Api.Models;

public class AnimalFoto
{
    public int Id { get; set; }
    public int AnimalId { get; set; }
    public string UrlImagem { get; set; } = string.Empty;
    public int Ordem { get; set; }   // menor = aparece primeiro na galeria

    public Animal Animal { get; set; } = null!;
}
