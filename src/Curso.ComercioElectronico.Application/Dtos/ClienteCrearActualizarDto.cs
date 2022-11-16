using System.ComponentModel.DataAnnotations;
using Curso.ComercioElectronico.Domain;

namespace Curso.ComercioElectronico.Application;

public class ClienteCrearActualizarDto {

 
    [Required]
    [StringLength(DominioConstantes.NOMBRE_MAXIMO)]
    public string Nombres {get;set;}
    
    public string Apellidos { get;set; }

    public string Cedula { get; set; }

    public string Direccion { get; set; }
    
    public int Telefono { get; set; }
}