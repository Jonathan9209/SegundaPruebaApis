using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.ComercioElectronico.Application;

public interface IAutorAppService
{
    ICollection<AutorDto> GetAll();
    Task<AutorDto> CreateAsync(AutorCrearActualizarDto autorDto);
    Task UpdateAsync (int id, AutorCrearActualizarDto autorDto);
    Task<bool> DeleteAsync(int id);
}