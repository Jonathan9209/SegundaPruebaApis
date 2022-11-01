using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso.ComercioElectronico.Domain;
using Microsoft.EntityFrameworkCore;

namespace Curso.ComercioElectronico.Infraestructure;

public class EditorialRepository : EfRepository<Editorial>, IEditorialRepository
{
    public EditorialRepository(ComercioElectronicoDbContext context): base(context)
    {
    }

    public async Task<bool> ExistName(string name)
    {
        var resultado = await this._context.Set<Editorial>()
                                  .AnyAsync(x => x.Name.ToUpper() == name.ToUpper());
        
        return resultado;
    }

    public async Task<bool> ExistName(string name, int idExclud)
    {
        var query = this._context.Set<Editorial>()
                        .Where(x => x.Id != idExclud)
                        .Where(x => x.Name.ToUpper() == name.ToUpper());
        
        var resultado = await query.AnyAsync();
        return resultado;
    }
}