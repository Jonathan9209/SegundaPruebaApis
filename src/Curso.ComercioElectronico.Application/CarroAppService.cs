using Curso.ComercioElectronico.Domain;
using Microsoft.Extensions.Logging;

namespace Curso.ComercioElectronico.Application;

public class CarroAppService : ICarroAppService
{
    private readonly IOrdenRepository ordenRepository;
    private readonly IProductoAppService productoAppService;
    private readonly ILogger<OrdenAppService> logger;

    public static Task<CarroDto> CreateAsync(CarroCrearActualizarDto carro)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AnularAsync(Guid carroId)
    {
        throw new NotImplementedException();
    }

    public Task<CarroDto> CreateAsync(CarroDto carro)
    {
        throw new NotImplementedException();
    }

    public ListaPaginada<OrdenDto> GetAll(int limit = 10, int offset = 0)
    {
        throw new NotImplementedException();
    }

    public Task<OrdenDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Guid id, OrdenActualizarDto marca)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Guid id, CarroCrearActualizarDto carro)
    {
        throw new NotImplementedException();
    }
}

