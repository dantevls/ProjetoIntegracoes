using Domain.MercadoLivre;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.MercadoLivre.Mapping;

public class UsuarioMercadoLivreMapping : IEntityTypeConfiguration<UsuarioMercadoLivre>
{
    public void Configure(EntityTypeBuilder<UsuarioMercadoLivre> builder)
    {
        builder.Property(x => x.Id)
            .IsRequired()
            .HasColumnName("UsuarioId");
        
        builder.Property(x => x.Token)
            .HasColumnName("Token");

        builder.Property(x => x.Client_Id)
            .HasColumnName("Client_Id");
        
        builder.Property(x => x.Client_Secret)
            .HasColumnName("Client_Secret");

        builder.ToTable("UsuarioMercadoLivre", "MercadoLivre");
    }
}