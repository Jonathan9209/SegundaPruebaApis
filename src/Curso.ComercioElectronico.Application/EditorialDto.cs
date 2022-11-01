using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Curso.ComercioElectronico.Domain;

namespace  Curso.ComercioElectronico.Application;

public class EditorialDto
{
    [Required]
    public int Id {get; set;}
    
    [Required]
    [StringLength(Constants.NAME_MAX_LEN)]
    public string? Name {get; set;} 
}