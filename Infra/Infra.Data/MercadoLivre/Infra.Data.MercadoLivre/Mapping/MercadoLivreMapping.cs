using Domain.MercadoLivre;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.MercadoLivre.Mapping;

public class MercadoLivreMapping : IEntityTypeConfiguration<Anuncio>
{
    public void Configure(EntityTypeBuilder<Anuncio> builder)
    {
        builder.ToTable("MercadoLivreAnuncio");

        builder.Property(x => x.UsuarioId)
            .IsRequired()
            .HasColumnName("UsuarioId");

        builder.HasOne(x => x.Plano)
            .WithMany(p => p.Anuncio)
            .HasForeignKey(a => a.PlanoId);

        builder.Property(x => x.PlanoId)
            .IsRequired()
            .HasColumnName("PlanoId");

        builder.Property(x => x.SistemaExternoId)
            .IsRequired()
            .HasColumnName("SistemaExternoId");       
        
        builder.Property(x => x.Titulo)
            .IsRequired()
            .HasColumnName("Titulo");       
        
        builder.Property(x => x.Descricao)
            .HasColumnName("Descricao");  
        
        builder.Property(x => x.Preco)
            .HasColumnName("Preco")
            .IsRequired();
        
        builder.Property(x => x.TipoProduto)
            .HasColumnName("TipoProduto");

        builder.ToTable("Anuncio", "MercadoLivre");
    }
}