using Application.MercadoLivre.ViewModels.Plano;
using AutoMapper;
using Domain.MercadoLivre;

namespace Application.MercadoLivre.AutoMapper;

public class DomainToViewModelProfile : Profile
{
    public DomainToViewModelProfile()
    {
        CreateMap<Plano, PlanoViewModel>();
    }
}