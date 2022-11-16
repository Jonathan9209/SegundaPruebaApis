using System.ComponentModel.DataAnnotations;
using Curso.ComercioElectronico.Domain;

namespace Curso.ComercioElectronico.Application;

public class CalificacionCrearActualizarDto {

    [Required]
    public int Valoracion {get;set;}
    

    [Required]
    public int ClienteId {get;set;}

    public string  Cliente {get; set; }


    [Required]
    public int ProductoId {get;set;}

    public string Producto {get;set;}

}
