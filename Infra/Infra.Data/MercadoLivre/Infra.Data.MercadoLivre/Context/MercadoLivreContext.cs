using Domain.MercadoLivre;
using Infra.Data.MercadoLivre.Mapping;
using Infra.Data.Util.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infra.Data.MercadoLivre.Context;

public class MercadoLivreContext : UtilContext<MercadoLivreContext>
{
    public MercadoLivreContext() : base()
    {
    }
    
    public DbSet<Anuncio> Anuncio { get; set; }
    public DbSet<UsuarioMercadoLivre> UsuarioMercadoLivre { get; set; }
    public DbSet<Plano> Plano { get; set; }

    protected static void OnConfiguring(DbContextOptionsBuilder optionsBuilder, IConfiguration configuration)
    {
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("ConnectionString") ?? "Server=localhost;Port=5432;Database=ProjetoIntegracoes;User Id=postgres;Password=Xxprodigi123;",
        b => b.MigrationsAssembly(typeof(MercadoLivreContext).Assembly.FullName));
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new MercadoLivreMapping());
        modelBuilder.ApplyConfiguration(new PlanoMapping());
        modelBuilder.ApplyConfiguration(new UsuarioMercadoLivreMapping());
    }

 
}