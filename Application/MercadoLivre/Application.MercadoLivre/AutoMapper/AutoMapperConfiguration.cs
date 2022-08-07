using AutoMapper;

namespace Application.MercadoLivre.AutoMapper;

public class AutoMapperConfiguration
{
    public static MapperConfiguration RegisterMappings()
    {
        return new MapperConfiguration(ps =>
        {
            ps.AddProfile(new ViewModelToDomainProfile());
            ps.AddProfile(new DomainToViewModelProfile());
        });
    }
}