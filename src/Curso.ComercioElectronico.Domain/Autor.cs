using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.ComercioElectronico;
public class Autor
{
    [Required]
    public int Id {get; set;}
    
    [Required]
    [StringLength(Constants.NAME_MAX_LEN)]
    public string? Name {get; set;}   
}