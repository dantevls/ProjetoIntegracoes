using Domain.MercadoLivre;
using Domain.MercadoLivre.Interfaces;
using Infra.Data.MercadoLivre.Context;
using Infra.Data.Util.Repository;

namespace Infra.Data.MercadoLivre.Repository;

public class PlanoRepository :  IPlanoRepository
{
    private MercadoLivreContext _context;
    public PlanoRepository(MercadoLivreContext context) : base()
    {
        _context = context;
    }

    public void IncluirPlano(Plano plano)
    {
        _context.Add(plano);
    }

    public Plano ObterPlano(Guid planoId)
    {
        var plano = _context.Find<Plano>(planoId);

        return plano;
    }
}