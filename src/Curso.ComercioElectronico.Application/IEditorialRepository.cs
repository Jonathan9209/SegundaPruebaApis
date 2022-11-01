using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.ComercioElectronico.Application;

public interface IEditorialAppService
{
    ICollection<EditorialDto> GetAll();
    Task<EditorialDto> CreateAsync(EditorialCrearActualizarDto editorialDto);
    Task UpdateAsync (int id, EditorialCrearActualizarDto editorialDto);
    Task<bool> DeleteAsync(int id);
}