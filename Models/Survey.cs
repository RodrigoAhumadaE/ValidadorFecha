#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using EcuestaDojoValidacion.Controllers;
namespace EcuestaDojoValidacion.Models;

public class Survey{
    [Required(ErrorMessage = "Por favor proporciona este dato!")]
    [MinLength(2, ErrorMessage="Tu nombre debe de tener al menos 2 caracteres.")]
    public string Nombre {get;set;}

    [Required(ErrorMessage = "Por favor proporciona este dato!")]
    public string Locacion {get;set;}

    [Required(ErrorMessage = "Por favor proporciona este dato!")]
    public string Lenguaje {get;set;}

    [MinLength(20, ErrorMessage="Tu comentario debe de tener al menos 20 caracteres.")]
    public string? Comentario {get;set;}

    [Required(ErrorMessage = "Por favor proporciona este dato!")]
    [FechaFutura]
    public DateTime FechaNacimiento {get;set;}
    public string Fecha {
        get{ return FechaNacimiento.ToShortDateString();}
    }
}