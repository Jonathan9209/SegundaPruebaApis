namespace Curso.ComercioElectronico.Domain;

public interface ICalificacionRepository : IRepository<Calificacion, string>
{
    Task GetByIdAsync(int calificacionId);
}