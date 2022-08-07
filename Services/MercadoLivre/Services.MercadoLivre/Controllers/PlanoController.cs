using Application.MercadoLivre.Interfaces;
using Application.MercadoLivre.ViewModels.Plano;
using Microsoft.AspNetCore.Mvc;

namespace Services.MercadoLivre.Controllers;

public class PlanoController : ControllerBase
{
    private IPlanosAppService _planoAppService;

    public PlanoController(IPlanosAppService planoAppService)
    {
        _planoAppService = planoAppService;
    }
    
    [HttpPost]
    [Route("api/Plano")]
    public Guid InserirPlano(InserirPlanoViewModel plano)
    {
        var planoId = _planoAppService.InserirPlano(plano);

        return planoId;
    }
    
    [HttpGet]
    [Route("api/Plano")]
    public PlanoViewModel ObterPlano(Guid planoId)
    {
        var plano = _planoAppService.ObterPlano(planoId);

        return plano;
    }
    
    
    
}