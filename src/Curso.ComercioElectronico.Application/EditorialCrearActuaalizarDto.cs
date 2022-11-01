using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Curso.ComercioElectronico.Domain;

namespace Curso.ComercioElectronico.Application;

public class EditorialCrearActualizarDto
{
    [Required]
    [StringLength(Constants.NAME_MAX_LEN)]
    public string? Name {get; set;} 
}