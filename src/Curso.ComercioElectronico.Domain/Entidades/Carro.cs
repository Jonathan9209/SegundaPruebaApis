using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Curso.ComercioElectronico.Domain;

public class Carro
{

    public Carro(Guid id){
        this.Id = id;
    }


    [Required]
    public Guid Id {get;set; }
 
    [Required]
    public Guid CarroId {get;set;}
   
    public virtual Cliente Cliente {get;set;}

    public virtual ICollection<CarroItem> Items {get;set;} = new List<CarroItem>();

    [Required]
    public DateTime Fecha {get;set;}


    [Required]
    public decimal Total {get;set;}



}

public class CarroItem {

    public CarroItem(Guid id){
        this.Id = id;
    }

    [Required]
    public Guid Id {get;set; }

    [Required]
    public int ProductId {get; set;}

    public virtual Producto Product { get; set; }

    [Required]
    public int CarroId {get; set;}

    public virtual Carro Carro { get; set; }

    [Required]
    public long Cantidad {get;set;}

    public decimal Precio {get;set;}

    
}
