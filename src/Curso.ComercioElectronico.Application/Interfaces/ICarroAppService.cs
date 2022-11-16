using System.ComponentModel.DataAnnotations;
using Curso.ComercioElectronico.Domain;

namespace Curso.ComercioElectronico.Application;


public interface ICarroAppService
{
    Task<OrdenDto> GetByIdAsync(Guid id);

    ListaPaginada<OrdenDto> GetAll(int limit=10,int offset=0);

    //ListaPaginada<OrdenDto> GetByClientIdAll(int clientId, int limit=10,int offset=0);


    Task<CarroDto> CreateAsync(CarroDto carro);

    Task UpdateAsync (Guid id, CarroCrearActualizarDto carro);

    Task<bool> AnularAsync(Guid carroId);
}

