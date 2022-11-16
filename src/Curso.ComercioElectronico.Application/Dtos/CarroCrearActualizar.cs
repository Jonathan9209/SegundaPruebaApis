using System.ComponentModel.DataAnnotations;
using Curso.ComercioElectronico.Domain;

namespace Curso.ComercioElectronico.Application;

public class CarroCrearActualizarDto {


    [Required]
    public Guid ClienteId {get;set; }
 

    public virtual ICollection<CarroItem> Items {get;set;} = new List<CarroItem>();

    [Required]
    public DateTime Fecha {get;set;}

    [Required]
    public decimal Total {get;set;}




public class CarroItemCrearActualizar {


    [Required]
    public int ProductId {get; set;}

    [Required]
    public long Cantidad {get;set;}

    public decimal Precio {get;set;}

    
}

}
