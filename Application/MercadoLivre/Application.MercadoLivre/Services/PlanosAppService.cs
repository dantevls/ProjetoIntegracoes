using Application.MercadoLivre.Interfaces;
using Application.MercadoLivre.ViewModels.Plano;
using AutoMapper;
using Domain.MercadoLivre;
using Domain.MercadoLivre.Interfaces;

namespace Application.MercadoLivre.Services;

public class PlanosAppService : IPlanosAppService
{
    public readonly IPlanoRepository _repository;
    public readonly IMapper _mapper;
    public PlanosAppService(IPlanoRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    public Guid InserirPlano(InserirPlanoViewModel planoViewModel)
    {
        var planoDomain = _mapper.Map<Plano>(planoViewModel);
        _repository.IncluirPlano(planoDomain);

        return planoDomain.Id;
    }
    public PlanoViewModel ObterPlano(Guid planoId)
    {
        var planoDomain = _repository.ObterPlano(planoId);

        var planoViewModel = _mapper.Map<PlanoViewModel>(planoDomain);

        return planoViewModel;
    }
}