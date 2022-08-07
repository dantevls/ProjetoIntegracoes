using Application.MercadoLivre.ViewModels.Plano;

namespace Application.MercadoLivre.Interfaces;

public interface IPlanosAppService
{
    Guid InserirPlano(InserirPlanoViewModel plano);
    PlanoViewModel ObterPlano(Guid planoId);
}