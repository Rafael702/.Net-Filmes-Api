using System.Security.Cryptography;

namespace FilmesApi.Controllers;

public class Filme
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }
}