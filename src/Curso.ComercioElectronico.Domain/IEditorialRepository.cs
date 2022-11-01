using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.ComercioElectronico;

public interface IEditorialRepository: IRepository<Editorial>
{
    Task<bool> ExistName(string name);
    Task<bool> ExistName(string name, int idExclud);

}