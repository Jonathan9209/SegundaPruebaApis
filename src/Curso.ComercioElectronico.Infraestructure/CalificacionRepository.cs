using Curso.ComercioElectronico.Domain;

namespace Curso.ComercioElectronico.Infraestructure;

public class CalificacionRepository : EfRepository<Calificacion,Guid>, ICalificacionRepository
{
    public CalificacionRepository(ComercioElectronicoDbContext context) : base(context)
    {

    }

    Task<Calificacion> IRepository<Calificacion, string>.GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    Task ICalificacionRepository.GetByIdAsync(int calificacionId)
    {
        throw new NotImplementedException();
    }

    // Task ICalificacionRepository.GetByIdAsync(int calificacionId)
    // {
    //     throw new NotImplementedException();
    // }
}