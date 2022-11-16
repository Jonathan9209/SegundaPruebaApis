using Curso.ComercioElectronico.Domain;

namespace Curso.ComercioElectronico.Application;

public class CalificacionAppService : ICalificacionAppService
{
    private readonly ICalificacionRepository calificacionRepository;
    private readonly IClienteRepository clienteRepository;
    private readonly IProductoRepository productoRepository;

    public CalificacionAppService(ICalificacionRepository calificacionRepository,
            IClienteRepository clienteRepository,
            IProductoRepository ProductoRepository)
    {
        this.calificacionRepository = calificacionRepository;
        this.clienteRepository = clienteRepository;
        this.productoRepository = productoRepository;
    }

    Task<ProductoDto> ICalificacionAppService.CreateAsync(CalificacionCrearActualizarDto calificacion)
    {
        throw new NotImplementedException();
    }

    Task<bool> ICalificacionAppService.DeleteAsync(int productoId)
    {
        throw new NotImplementedException();
    }

    ListaPaginada<CalificacionDto> ICalificacionAppService.GetAll(int limit, int offset)
    {
        throw new NotImplementedException();
    }

    Task<CalificacionDto> ICalificacionAppService.GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task ICalificacionAppService.UpdateAsync(int id, CalificacionCrearActualizarDto calificacion)
    {
        throw new NotImplementedException();
    }
}

