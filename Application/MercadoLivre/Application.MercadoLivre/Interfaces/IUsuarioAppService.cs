using Application.MercadoLivre.ViewModels;

namespace Application.MercadoLivre.Interfaces;

public interface IUsuarioAppService
{
    public MercadoLivreResponseViewModel? GetTokenOAuth(string state, string code);
}