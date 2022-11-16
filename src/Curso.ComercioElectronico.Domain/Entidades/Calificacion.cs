using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curso.ComercioElectronico.Domain;

public class Calificacion
{
    [Required]
    public int Id {get;set;}

    public int Valoracion {get;set;}
    

    [Required]
    public int ProductoId {get;set;}

    public virtual Producto Producto {get;set;}

      [Required]
     public int ClienteId {get;set;}

     public virtual Cliente Cliente {get;set;}

    
}

