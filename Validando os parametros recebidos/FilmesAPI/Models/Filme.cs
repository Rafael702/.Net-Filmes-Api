using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace FilmesApi.Controllers;

public class Filme
{
    [Required(ErrorMessage = "O Titulo do filme deve ser preenchido")]
    [MaxLength(50, ErrorMessage = "O Tamanho do Titulo Nao pode exceder 50 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O Genero do filme deve ser preenchido")]
    [StringLength(50, ErrorMessage = "O Tamanho do Genero Nao pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A Duracao do filme deve ser preenchido")]
    [Range(70, 600, ErrorMessage = "A Duracao deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}