using Domain.Util;
using Infra.Data.Util.Context;

namespace Infra.Data.Util.Repository;

public abstract class UtilRepository<Entity> where Entity : BaseEntity<Entity>
{
    // private UtilContext<> Db;
    //
    // public UtilRepository(UtilContext context)
    // {
    //     Db = context;
    // }
    //
    // protected UtilRepository()
    // {
    //     throw new NotImplementedException();
    // }
}