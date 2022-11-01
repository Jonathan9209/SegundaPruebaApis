using Curso.ComercioElectronico.Domain;
using Microsoft.EntityFrameworkCore;

namespace Curso.ComercioElectronico.Infraestructure;

public class ComercioElectronicoDbContext:DbContext, IUnitOfWork
{

    //Agregar sus entidades
    public DbSet<Autor> Autores {get;set;}
    

    public string DbPath { get; set; }

    public ComercioElectronicoDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "curso.comercio-electronico.db");
 
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

} 
