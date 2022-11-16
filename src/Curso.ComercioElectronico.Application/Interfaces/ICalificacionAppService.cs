namespace Curso.ComercioElectronico.Application;

public interface ICalificacionAppService
{
    Task<CalificacionDto> GetByIdAsync(int id);

    //Permitir filtrar marca,tipo producto, y por texto (nombre,codigo). Paginacion.
    ListaPaginada<CalificacionDto> GetAll(int limit=10,int offset=0);

/*     ListaPaginada<ProductoDto> GetList(int limit=10,int offset=0,string? tipoProductoId="",
                        string? marcaId="",string? valorBuscar=""); */

    // Task<ListaPaginada<CalificacionDto>> GetListAsync(CalificacionListInput input);


    Task<ProductoDto> CreateAsync(CalificacionCrearActualizarDto calificacion);

    Task UpdateAsync (int id, CalificacionCrearActualizarDto calificacion);

    Task<bool> DeleteAsync(int productoId);
}
