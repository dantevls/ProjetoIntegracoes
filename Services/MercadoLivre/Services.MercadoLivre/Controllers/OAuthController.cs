using Application.MercadoLivre.Interfaces;
using Application.MercadoLivre.ViewModels;
using Application.MercadoLivre.ViewModels.Plano;
using Microsoft.AspNetCore.Mvc;

namespace Services.MercadoLivre.Controllers;

public class OAuthController : ControllerBase
{
    private IUsuarioAppService _mercadoLivreAppService;
   
    public OAuthController(IUsuarioAppService mercadoLivreAppSerivce)
    {
        _mercadoLivreAppService = mercadoLivreAppSerivce;
    }

    [HttpGet]
    [Route("api/MercadoLivre")]
    public MercadoLivreResponseViewModel OAuthMercadoLivre(string code, string state)
    {

        if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(state))
            throw new Exception("Não foi possível obter os dados vindos do mercado livre");
        
        var responseViewModel = _mercadoLivreAppService.GetTokenOAuth(code, state);

        return responseViewModel;
    }
}