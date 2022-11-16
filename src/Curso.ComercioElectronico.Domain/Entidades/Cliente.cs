using System.ComponentModel.DataAnnotations;

namespace Curso.ComercioElectronico.Domain;

public class Cliente {

    [Required]
    public Guid Id {get;set;}

    [Required]
    public string Cedula {get;set;}

    [Required]
    [StringLength(DominioConstantes.NOMBRE_MAXIMO)]
    public string Nombres {get;set;}

    [Required]
    [StringLength(DominioConstantes.NOMBRE_MAXIMO)]
    public string Apellidos {get;set;}
   
    [Required]
    public string Direccion {get;set;}

    [Required]
    public int Telefono {get;set;}

     
}
