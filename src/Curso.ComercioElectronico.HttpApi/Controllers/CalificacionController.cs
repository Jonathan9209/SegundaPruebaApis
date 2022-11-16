using Curso.ComercioElectronico.Application;
using Microsoft.AspNetCore.Mvc;

namespace Curso.ComercioElectronico.HttpApi.Controllers;


[ApiController]
[Route("[controller]")]
public class CalificacionController : ControllerBase
{

    private readonly ICalificacionAppService calificacionAppService;

    public CalificacionController(ICalificacionAppService califiacionAppService)
    {
        this.calificacionAppService = califiacionAppService;
    }

    [HttpGet]
    public ListaPaginada<CalificacionDto> GetAll(int limit=10,int offset=0)
    {

        return calificacionAppService.GetAll(limit,offset);

    }
    
    [HttpPost]
    public async Task<ProductoDto> CreateAsync(CalificacionCrearActualizarDto calificacion)
    {

        return await calificacionAppService.CreateAsync(calificacion);

    }

    [HttpPut]
    public async Task UpdateAsync(int id, CalificacionCrearActualizarDto calificacion)
    {

        await calificacionAppService.UpdateAsync(id, calificacion);

    }

    [HttpDelete]
    public async Task<bool> DeleteAsync(int calificacionId)
    {

        return await calificacionAppService.DeleteAsync(calificacionId);

    }

}