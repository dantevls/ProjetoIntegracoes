using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;

namespace Infra.Data.Util.Context;

public abstract class UtilContext<TContext> : DbContext
{
    public UtilContext() : base() 
    { }
    
    protected static void OnConfiguring(DbContextOptionsBuilder optionsBuilder, IConfiguration configuration)
    {
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("ConnectionString") ?? "Server=localhost;Port=5432;Database=ProjetoIntegracoes;User Id=postgres;Password=Xxprodigi123;",
            b => b.MigrationsAssembly(typeof(TContext).Assembly.FullName));
    }
    
    public override EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class
    {
        var buff = SetControls(entity);
        entity = buff;

        return base.Add(entity);
    }
    
    public override EntityEntry<TEntity> Update<TEntity>(TEntity entity)
    {
        SetControls(entity);

        return base.Update(entity);
    }

    public dynamic SetControls<TEntity>(TEntity entity) 
    {
        dynamic buff = entity;
        if (buff.Control_DataInc != null)
            buff.Control_DataInc = DateTimeOffset.Now;
        
        buff.Control_DataAlter = DateTimeOffset.Now;

        return buff;
    }

}