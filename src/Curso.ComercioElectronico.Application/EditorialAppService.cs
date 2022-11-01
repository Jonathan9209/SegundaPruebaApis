using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso.ComercioElectronico.Domain;

namespace Curso.ComercioElectronico.Application;

public class EditorialAppService : IEditorialAppService
{
    private readonly IEditorialRepository repository;
    public EditorialAppService(IEditorialRepository repository)
    {
            this.repository = repository;
    }

    public async Task<EditorialDto> CreateAsync(EditorialCrearActualizarDto editorialDto)
    {
        var existNameEditorial = await repository.ExistName(editorialDto.Name);
        if(existNameEditorial)
        {
            throw new ArgumentException($"Ya exite un Editorial con el nombre {editorialDto.Name}");
        }

        var editorial = new Editorial();
        editorial.Name = editorialDto.Name;

        editorial = await repository.AddAsync(editorial);

        var editorialCreado = new EditorialDto();
        editorialCreado.Name = editorial.Name;
        editorialCreado.Id = editorial.Id;

        return editorialCreado;
    }

    public async Task<bool> DeleteAsync(int editorialId)
    {
        var editorial = await repository.GetByIdAsync(editorialId);
        if (editorial == null)
        {
            throw new ArgumentException($"El editorial con el id: {editorialId}, no existe"); 
        }

        repository.Delete(editorial);

        return true;
    }

    public ICollection<EditorialDto> GetAll()
    {
        var editorialLista = repository.GetAll();

        var editorialListaDto = from e in editorialLista
                                 select new EditorialDto{
                                    Id = e.Id,
                                    Name = e.Name
                                 };

        return editorialListaDto.ToList();
    }

    public async Task UpdateAsync(int id, EditorialCrearActualizarDto editorialDto)
    {
        var editorial = await repository.GetByIdAsync(id);
        if (editorial == null)
        {
            throw new ArgumentException($"El editorial con el id: {id} no existe!!");
        }

        var existNameEditorial = await repository.ExistName(editorialDto.Name, id);
        if (existNameEditorial)
        {
            throw new ArgumentException($"Ya existe un Editorial con el nombre: {editorialDto.Name}");   
        }

        editorial.Name = editorialDto.Name;

        await repository.UpdateAsync(editorial);

        return;
    }
}