using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Curso.ComercioElectronico.Domain;
using Curso.ComercioElectronico.Infraestructure;
using Microsoft.EntityFrameworkCore;

namespace Curso.ComercioElectronico;

public abstract class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly ComercioElectronicoDbContext _context;

    protected EfRepository(ComercioElectronicoDbContext context)
    {
        _context = context;
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        await _context.SaveChangesAsync();
        
        return entity;
    }

    public virtual void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        _context.SaveChangesAsync();

    }

    public virtual IQueryable<TEntity> GetAll(bool asNoTracking = true)
    {
        if(asNoTracking)
            return _context.Set<TEntity>().AsNoTracking();
        else
            return _context.Set<TEntity>().AsQueryable();
    }

    public virtual IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> queryable = GetAll();
        foreach (Expression<Func<TEntity, object>> includeProperty in includeProperties)
        {
            queryable = queryable.Include<TEntity, object>(includeProperty);
        }
        return queryable;
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
        return;
    }
}