using Microsoft.AspNetCore.Mvc;           // traz Route, ApiController, ControllerBase, Ok, NotFound

namespace PawsPlace.Api.Controllers;      // "endereço" da classe, igual ao WeatherForecastController

public record Animal(int Id, string Nome, string Especie, string Idade);

[ApiController]                           // atributos ficam EM CIMA da classe
[Route("api/animais")]
public class AnimaisController : ControllerBase
{
    // static = uma única lista compartilhada, que vive enquanto a API estiver rodando
    private static readonly List<Animal> Animais =
    [
        new Animal(1, "Nespresso", "gato", "5 Meses"),
        new Animal(2, "Santo Grão", "gato", "5 Meses"),
        new Animal(3, "Pilão", "gato", "5 Meses")
    ];

    [HttpGet]
    public IActionResult Listar()
    {
        return Ok(Animais);
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
        var animal = Animais.FirstOrDefault(a => a.Id == id);
        if (animal is null)
        {
            return NotFound();
        }

        return Ok(animal);
    }
}