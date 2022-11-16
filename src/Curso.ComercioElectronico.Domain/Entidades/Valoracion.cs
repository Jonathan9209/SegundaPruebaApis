using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curso.ComercioElectronico.Domain;


public class Valoracion
{
    [Required]
    public int Id {get;set;}

    public int Calificacion {get;set;}
    

    [Required]
    public int ProductoId {get;set;}

    public virtual Producto Producto {get;set;}

    
}

