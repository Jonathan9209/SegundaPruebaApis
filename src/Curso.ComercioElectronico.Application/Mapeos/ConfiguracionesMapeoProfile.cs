

using AutoMapper;
using Curso.ComercioElectronico.Application;
using Curso.ComercioElectronico.Domain;

public class ConfiguracionesMapeoProfile : Profile
{
    //TipoProductoCrearActualizarDto => TipoProducto
    //TipoProducto => TipoProductoDto
    public ConfiguracionesMapeoProfile()
    {
        CreateMap<TipoProductoCrearActualizarDto, TipoProducto>();
        CreateMap<TipoProducto, TipoProductoDto>();
        CreateMap<ClienteCrearActualizarDto, Cliente>();
        CreateMap<Cliente, ClienteDto>();
        CreateMap<MarcaCrearActualizarDto, MarcaDto>();
        CreateMap<Marca, MarcaDto>();
        CreateMap<ProductoCrearActualizarDto, Producto>();
        CreateMap<Producto, ProductoDto>();
        CreateMap<OrdenActualizarDto, Orden>();
        CreateMap<Orden, OrdenDto>();

    
    }
}

