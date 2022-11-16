using AutoMapper;
using Curso.ComercioElectronico.Domain;
using Microsoft.Extensions.Logging;

namespace Curso.ComercioElectronico.Application;

public class TipoProductoAppService : ITipoProductoAppService
{
    private readonly ITipoProductoRepository tipoProductoRepository;
    private readonly IMapper mapper;
    private readonly ILogger<TipoProductoAppService> logger;

    public TipoProductoAppService(ITipoProductoRepository tipoProductoRepository,
        IMapper mapper,
        ILogger<TipoProductoAppService> logger )
    {
        this.tipoProductoRepository = tipoProductoRepository;
        this.mapper = mapper;
        this.logger = logger;
    }

    public async Task<TipoProductoDto> CreateAsync(TipoProductoCrearActualizarDto tipoProductoDto)
    {
       
        logger.LogInformation("Crear Tipo Producto");

        //Mapeo Dto => Entidad. (Manual)
        //var tipoProducto = new TipoProducto();
        //tipoProducto.Nombre = tipoProductoDto.Nombre;
 
        //Automatico
        var tipoProducto = mapper.Map<TipoProducto>(tipoProductoDto);

        //Persistencia objeto
        tipoProducto = await tipoProductoRepository.AddAsync(tipoProducto);
        await tipoProductoRepository.UnitOfWork.SaveChangesAsync();

        //Mapeo Entidad => Dto
        //var tipoProductoCreada = new TipoProductoDto();
        //tipoProductoCreada.Nombre = tipoProducto.Nombre;
        //tipoProductoCreada.Id = tipoProducto.Id;

         var tipoProductoCreada = mapper.Map<TipoProductoDto>(tipoProducto);

 
        return tipoProductoCreada;
    }

    public async Task<bool> DeleteAsync(int tipoProductoId)
    {
        //Reglas Validaciones... 
        var tipoProducto = await tipoProductoRepository.GetByIdAsync(tipoProductoId);
        if (tipoProducto == null){
            throw new ArgumentException($"El tipoproducto con el id: {tipoProductoId}, no existe");
        }

        tipoProductoRepository.Delete(tipoProducto);
        //await unitOfWork.SaveChangesAsync();

        return true;
    }

     public ICollection<TipoProductoDto> GetAll()
    {
        var tipoProductoList = tipoProductoRepository.GetAll();

        var tipoProductoListDto =  from tp in tipoProductoList
                            select new TipoProductoDto(){
                                Id = tp.Id,
                                Nombre = tp.Nombre
                            };

        return tipoProductoListDto.ToList();
    }

    public ListaPaginada<TipoProductoDto> GetAll(int limit = 10, int offset = 0)
    {
        throw new NotImplementedException();
    }

    public Task<TipoProductoDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(int id, TipoProductoCrearActualizarDto marca)
    {
    //      var tipoProducto = await tipoProductoRepository.GetByIdAsync(id);
    //     if (tipoProducto == null){
    //         throw new ArgumentException($"El TipoProducto con el id: {id}, no existe");
    //     }

    //         tipoProducto.Nombre = TipoProductoDto.Nombre;
         
    //    await tipoProductoRepository.UpdateAsync(tipoProducto);
    //    await tipoProductoRepository.UnitOfWork.SaveChangesAsync();
    //    return;
    }
}

