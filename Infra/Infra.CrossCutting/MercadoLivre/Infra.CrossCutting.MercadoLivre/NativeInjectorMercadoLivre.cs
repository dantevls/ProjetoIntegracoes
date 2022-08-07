using Application.MercadoLivre.AutoMapper;
using Application.MercadoLivre.Interfaces;
using Application.MercadoLivre.Services;
using Domain.MercadoLivre.Interfaces;
using Infra.Data.MercadoLivre.Context;
using Infra.Data.MercadoLivre.Repository;
using Infra.Data.Util.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.CrossCutting.MercadoLivre;

public static class NativeInjectorMercadoLivre
{
    public static void AddInfra(this IServiceCollection services)
    {
        //Services
        services.AddScoped<HttpClient>();
        services.AddScoped<IUsuarioAppService, UsuarioAppService>();
        services.AddScoped<IPlanosAppService, PlanosAppService>();
       
        
        //Repository
        services.AddScoped<IPlanoRepository, PlanoRepository>();
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();

        //Context
        services.AddDbContext<MercadoLivreContext>();

        //Mapper
        services.AddAutoMapper(typeof(AutoMapperConfiguration));
    }
}
