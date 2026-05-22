using PawsPlace.Api.Models;
using PawsPlace.Api.Models.Enums;

namespace PawsPlace.Api.Data;

public static class Seed
{
    public static void PopularAnimais(AppDbContext db)
    {
        if (db.Animais.Any()) return;

        var entrada2024 = new DateTime(2024, 3, 1, 0, 0, 0, DateTimeKind.Utc);
        var entrada2023 = new DateTime(2023, 6, 15, 0, 0, 0, DateTimeKind.Utc);
        var entrada2025 = new DateTime(2025, 1, 10, 0, 0, 0, DateTimeKind.Utc);
        var entrada2026 = new DateTime(2026, 2, 5, 0, 0, 0, DateTimeKind.Utc);

        var animais = new List<Animal>
        {
            new() {
                Slug = "nespresso", Nome = "Nespresso", Especie = "gato",
                Idade = "5 Meses", IdadeMeses = 5,
                Imagem = "https://adoteumgatinho.org.br/media/uploads/cats/cf18cf45b86e195fec98c438f1a90e36.JPG",
                LinkDetalhes = "https://adoteumgatinho.org.br/detalhes-gato/20553/nespresso",
                Sexo = Sexo.Macho, Porte = Porte.Pequeno, Castrado = false, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Filhote curioso e brincalhão. Adora escalar e explorar cada cantinho da casa. Se dá bem com crianças e outros gatos.",
                DataEntrada = entrada2026,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://adoteumgatinho.org.br/media/uploads/cats/cf18cf45b86e195fec98c438f1a90e36.JPG" }
                }
            },
            new() {
                Slug = "pilao", Nome = "Pilão", Especie = "gato",
                Idade = "5 Meses", IdadeMeses = 5,
                Imagem = "https://adoteumgatinho.org.br/media/uploads/cats/00a6f69c309b2387294a28b6ff252da1.jpeg",
                LinkDetalhes = "https://adoteumgatinho.org.br/detalhes-gato/20552/pil%C3%A3%C2%A3o",
                Sexo = Sexo.Macho, Porte = Porte.Pequeno, Castrado = false, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Gato docinho e tranquilo. Adora colo e ronrona muito. Perfeito para quem quer um companheiro calmo.",
                DataEntrada = entrada2026,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://adoteumgatinho.org.br/media/uploads/cats/00a6f69c309b2387294a28b6ff252da1.jpeg" }
                }
            },
            new() {
                Slug = "santo-grao", Nome = "Santo Grão", Especie = "gato",
                Idade = "5 Meses", IdadeMeses = 5,
                Imagem = "https://adoteumgatinho.org.br/media/uploads/cats/fa8c070c5d79f6b9b466ab47c875c25a.jpg",
                LinkDetalhes = "https://adoteumgatinho.org.br/detalhes-gato/20551/santo-gr%C3%A3%C2%A3o",
                Sexo = Sexo.Macho, Porte = Porte.Pequeno, Castrado = false, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Um gato gentil e afetivo. Gosta de brincar com bolinhas e ficam horas olhando pela janela.",
                DataEntrada = entrada2026,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://adoteumgatinho.org.br/media/uploads/cats/fa8c070c5d79f6b9b466ab47c875c25a.jpg" }
                }
            },
            new() {
                Slug = "starbucks", Nome = "Starbucks", Especie = "gato",
                Idade = "5 Meses", IdadeMeses = 5,
                Imagem = "https://adoteumgatinho.org.br/media/uploads/cats/c94e8359c9dbb8ae34961388c25b8865.JPG",
                LinkDetalhes = "https://adoteumgatinho.org.br/detalhes-gato/20550/starbucks",
                Sexo = Sexo.Macho, Porte = Porte.Pequeno, Castrado = false, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Ativo e cheio de energia! Precisará de brinquedos e espaço para explorar. Convive bem com outros felinos.",
                DataEntrada = entrada2026,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://adoteumgatinho.org.br/media/uploads/cats/c94e8359c9dbb8ae34961388c25b8865.JPG" }
                }
            },
            new() {
                Slug = "the-coffee", Nome = "The Coffee", Especie = "gato",
                Idade = "5 Meses", IdadeMeses = 5,
                Imagem = "https://adoteumgatinho.org.br/media/uploads/cats/1a6771fb0d7a2ccaaab2bc99041e5e14.JPG",
                LinkDetalhes = "https://adoteumgatinho.org.br/detalhes-gato/20549/the-coffee",
                Sexo = Sexo.Femea, Porte = Porte.Pequeno, Castrado = false, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Gatinha independente mas carinhosa na hora certa. Adapta-se bem a apartamentos e rotinas tranquilas.",
                DataEntrada = entrada2026,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://adoteumgatinho.org.br/media/uploads/cats/1a6771fb0d7a2ccaaab2bc99041e5e14.JPG" }
                }
            },
            new() {
                Slug = "lady-gaga", Nome = "Lady Gaga", Especie = "gato",
                Idade = "1 Ano", IdadeMeses = 12,
                Imagem = "https://adoteumgatinho.org.br/media/uploads/cats/d5c9727bf0b01a0f2b66d14ce3cb5338.jpg",
                LinkDetalhes = "https://adoteumgatinho.org.br/detalhes-gato/20530/lady-gaga",
                Sexo = Sexo.Femea, Porte = Porte.Pequeno, Castrado = true, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Diva do abrigo! Elegante, esperta e muito sociável. Já castrada e vacinada. Adora atenção e ronrona alto.",
                DataEntrada = entrada2025,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://adoteumgatinho.org.br/media/uploads/cats/d5c9727bf0b01a0f2b66d14ce3cb5338.jpg" }
                }
            },
            new() {
                Slug = "topazio", Nome = "Topázio", Especie = "cachorro",
                Idade = "7 Anos", IdadeMeses = 84,
                Imagem = "https://acaochego.org/img/cachorros/946/topazio11.jpg",
                LinkDetalhes = "https://acaochego.org/Cachorro/Adotar/946",
                Sexo = Sexo.Macho, Porte = Porte.Grande, Castrado = true, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Cão adulto e equilibrado. Ótimo companheiro para corridas matinais. Convive bem com crianças maiores. Busca lar tranquilo.",
                DataEntrada = entrada2023,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://acaochego.org/img/cachorros/946/topazio11.jpg" }
                }
            },
            new() {
                Slug = "ametista", Nome = "Ametista", Especie = "cachorro",
                Idade = "6 Anos", IdadeMeses = 72,
                Imagem = "https://acaochego.org/img/cachorros/980/ametista1.jpg",
                LinkDetalhes = "https://acaochego.org/Cachorro/Adotar/980",
                Sexo = Sexo.Femea, Porte = Porte.Medio, Castrado = true, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Cadela serena e leal. Aprende rápido e adora agradar. Já castrada. Prefere ambientes calmos e família presente.",
                DataEntrada = entrada2023,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://acaochego.org/img/cachorros/980/ametista1.jpg" }
                }
            },
            new() {
                Slug = "tony", Nome = "Tony", Especie = "cachorro",
                Idade = "7 Anos", IdadeMeses = 84,
                Imagem = "https://acaochego.org/img/cachorros/968/filhote7_bela_1.jpg",
                LinkDetalhes = "https://acaochego.org/Cachorro/Adotar/968",
                Sexo = Sexo.Macho, Porte = Porte.Grande, Castrado = true, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Tony é um cão experiente e calmo. Gosta de longos passeios e depois descansar na varanda. Não se dá bem com outros cães.",
                DataEntrada = entrada2024,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://acaochego.org/img/cachorros/968/filhote7_bela_1.jpg" }
                }
            },
            new() {
                Slug = "romeu", Nome = "Romeu", Especie = "cachorro",
                Idade = "1 Ano", IdadeMeses = 12,
                Imagem = "https://adotar.com.br/upload/2026-03/animais_imagem1339710.jpg?w=700&format=webp",
                LinkDetalhes = "https://adotar.com.br/pr-curitiba/cao/adocao/romeu/333257",
                Sexo = Sexo.Macho, Porte = Porte.Medio, Castrado = false, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Jovem e cheio de vida! Romeu ama brincar com bola e adora crianças. Está aprendendo comandos básicos. Precisa de exercício diário.",
                DataEntrada = entrada2025,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://adotar.com.br/upload/2026-03/animais_imagem1339710.jpg?w=700&format=webp" }
                }
            },
            new() {
                Slug = "stallone", Nome = "Stallone", Especie = "cachorro",
                Idade = "2 Anos", IdadeMeses = 24,
                Imagem = "https://adotar.com.br/upload/2026-03/animais_imagem1338827.jpg?w=700&format=webp",
                LinkDetalhes = "https://adotar.com.br/pr-curitiba/cao/adocao/stallone/333028",
                Sexo = Sexo.Macho, Porte = Porte.Grande, Castrado = false, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Forte e protetor, mas muito dócil com a família. Stallone é leal e inteligente. Precisa de espaço para correr.",
                DataEntrada = entrada2025,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://adotar.com.br/upload/2026-03/animais_imagem1338827.jpg?w=700&format=webp" }
                }
            },
            new() {
                Slug = "espoleta", Nome = "Espoleta", Especie = "cachorro",
                Idade = "1 Ano", IdadeMeses = 12,
                Imagem = "https://adotar.com.br/upload/2026-02/animais_imagem1324836.jpg?w=700&format=webp",
                LinkDetalhes = "https://adotar.com.br/pr-curitiba/cao/adocao/espoleta/329403",
                Sexo = Sexo.Femea, Porte = Porte.Pequeno, Castrado = false, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Vive o nome! Espoleta é energia pura. Ótima pra quem tem vida ativa. Aprende truques na velocidade da luz.",
                DataEntrada = entrada2025,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://adotar.com.br/upload/2026-02/animais_imagem1324836.jpg?w=700&format=webp" }
                }
            },
            new() {
                Slug = "frederico", Nome = "Frederico", Especie = "cachorro",
                Idade = "3 Anos", IdadeMeses = 36,
                Imagem = "https://adotar.com.br/upload/2025-08/animais_imagem1257155.jpg?w=700&format=webp",
                LinkDetalhes = "https://adotar.com.br/pr-curitiba/cao/adocao/frederico/312406",
                Sexo = Sexo.Macho, Porte = Porte.Medio, Castrado = true, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Frederico é equilibrado e educado. Ótimo para famílias com crianças. Já castrado e vacinado. Um verdadeiro cavalheiro.",
                DataEntrada = entrada2024,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://adotar.com.br/upload/2025-08/animais_imagem1257155.jpg?w=700&format=webp" }
                }
            },
            new() {
                Slug = "batman", Nome = "Batman", Especie = "cachorro",
                Idade = "3 Meses", IdadeMeses = 3,
                Imagem = "https://adotar.com.br/upload/2025-10/animais_imagem1273245.jpg?w=700&format=webp",
                LinkDetalhes = "https://adotar.com.br/pr-curitiba/cao/adocao/nao-tem/316393",
                Sexo = Sexo.Macho, Porte = Porte.Pequeno, Castrado = false, Vacinado = false,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Filhotinho de 3 meses com muita energia e carinha de quem quer ser adotado logo! Ainda em fase de vacinação.",
                DataEntrada = entrada2026,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://adotar.com.br/upload/2025-10/animais_imagem1273245.jpg?w=700&format=webp" }
                }
            },
            new() {
                Slug = "banny", Nome = "Banny", Especie = "cachorro",
                Idade = "5 Anos", IdadeMeses = 60,
                Imagem = "https://img.pikbest.com/illustration/20250808/elegant-silhouette-of-a-dog-head-in-profile-perfect-for-logos-and-minimalist-designs_11821931.jpg!sw800",
                LinkDetalhes = null,
                Sexo = Sexo.Femea, Porte = Porte.Grande, Castrado = true, Vacinado = true,
                Cidade = "Curitiba", Estado = "PR",
                Descricao = "Banny espera há mais tempo que qualquer outro no abrigo. É carinhosa, obediente e merece uma segunda chance num lar.",
                DataEntrada = entrada2023,
                Fotos = new List<AnimalFoto> {
                    new() { Ordem = 1, UrlImagem = "https://img.pikbest.com/illustration/20250808/elegant-silhouette-of-a-dog-head-in-profile-perfect-for-logos-and-minimalist-designs_11821931.jpg!sw800" }
                }
            },
        };

        db.Animais.AddRange(animais);
        db.SaveChanges();
    }
}
