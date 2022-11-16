﻿using System.ComponentModel.DataAnnotations;

namespace Curso.ComercioElectronico.Domain;


public class Marca
{
    [Required]
    public string Id {get;set;}

    [Required]
    [StringLength(DominioConstantes.NOMBRE_MAXIMO)]
    public string Nombre {get;set;}

}




