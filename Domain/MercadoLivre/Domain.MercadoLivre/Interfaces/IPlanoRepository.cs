namespace Domain.MercadoLivre.Interfaces;

public interface IPlanoRepository
{
    public void IncluirPlano(Plano plano);
    public Plano ObterPlano(Guid planoId);
}