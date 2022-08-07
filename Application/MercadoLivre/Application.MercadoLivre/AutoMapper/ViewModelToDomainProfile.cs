

using Application.MercadoLivre.ViewModels;
using Application.MercadoLivre.ViewModels.Plano;
using AutoMapper;
using Domain.MercadoLivre;

namespace Application.MercadoLivre.AutoMapper;

public class ViewModelToDomainProfile : Profile
{
    public ViewModelToDomainProfile()
    {
        CreateMap<MercadoLivreResponseViewModel, UsuarioMercadoLivre>()
            .ForMember(x => x.DataExpiracao, src => src.MapFrom(x => x.Expires_In));

        CreateMap<InserirPlanoViewModel, Plano>()
            .ConstructUsing(src => new Plano(Guid.NewGuid(), src.QtdAnuncios, src.Nome, src.Status, src.Destaque));
    }
}