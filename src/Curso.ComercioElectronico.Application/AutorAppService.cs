using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso.ComercioElectronico.Domain;

namespace Curso.ComercioElectronico.Application;

public class AutorAppService : IAutorAppService
{
    private readonly IAutorRepository repository;
    public AutorAppService(IAutorRepository repository)
    {
            this.repository = repository;
    }

    public async Task<AutorDto> CreateAsync(AutorCrearActualizarDto autorDto)
    {
        var existNameAutor = await repository.ExistName(autorDto.Name);
        if(existNameAutor)
        {
            throw new ArgumentException($"Ya exite un autor con el nombre {autorDto.Name}");
        }

        var autor = new Autor();
        autor.Name = autorDto.Name;

        autor = await repository.AddAsync(autor);

        var autorCreado = new AutorDto();
        autorCreado.Name = autor.Name;
        autorCreado.Id = autor.Id;

        return autorCreado;
    }

    public async Task<bool> DeleteAsync(int autorId)
    {
        var autor = await repository.GetByIdAsync(autorId);
        if (autor == null)
        {
            throw new ArgumentException($"El autor con el id: {autorId}, no existe"); 
        }

        repository.Delete(autor);

        return true;
    }

    public ICollection<AutorDto> GetAll()
    {
        var autorLista = repository.GetAll();

        var autorListaDto = from e in autorLista
                                 select new AutorDto{
                                    Id = e.Id,
                                    Name = e.Name
                                 };

        return autorListaDto.ToList();
    }

    public async Task UpdateAsync(int id, AutorCrearActualizarDto autorDto)
    {
        var autor = await repository.GetByIdAsync(id);
        if (autor == null)
        {
            throw new ArgumentException($"El autor con el id: {id} no existe!!");
        }

        var existNameAutor = await repository.ExistName(autorDto.Name, id);
        if (existNameAutor)
        {
            throw new ArgumentException($"Ya existe un autor con el nombre: {autorDto.Name}");   
        }

        autor.Name = autorDto.Name;

        await repository.UpdateAsync(autor);

        return;
    }
}