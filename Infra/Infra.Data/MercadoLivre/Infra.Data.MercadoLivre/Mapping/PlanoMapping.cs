using Domain.MercadoLivre;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.MercadoLivre.Mapping;

public class PlanoMapping: IEntityTypeConfiguration<Plano>
{
    public void Configure(EntityTypeBuilder<Plano> builder)
    {
        builder.Property(x => x.Nome)
            .IsRequired();     
        
        builder.Property(x => x.QtdAnuncios)
            .IsRequired();   
        
        builder.Property(x => x.Status)
            .IsRequired();

        builder.Property(x => x.Destaque);

        builder.HasMany(x => x.Anuncio)
            .WithOne(x => x.Plano).HasForeignKey(x => x.PlanoId);

        builder.ToTable("Plano", "MercadoLivre");
    }
}