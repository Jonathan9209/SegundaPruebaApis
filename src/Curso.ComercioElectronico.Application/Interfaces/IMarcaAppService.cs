using System.ComponentModel.DataAnnotations;
using Curso.ComercioElectronico.Domain;

namespace Curso.ComercioElectronico.Application;


public interface IMarcaAppService
{

    ICollection<MarcaDto> GetAll();

    Task<MarcaDto> CreateAsync(MarcaCrearActualizarDto marca);

    Task UpdateAsync (string id, MarcaCrearActualizarDto marca);

    Task<bool> DeleteAsync(string marcaId);
}
 
