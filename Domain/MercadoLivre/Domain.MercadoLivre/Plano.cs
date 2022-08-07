using Domain.Util;

namespace Domain.MercadoLivre;

public class Plano : BaseEntity<Plano>
{
    public decimal QtdAnuncios { get; set; }
    public string Nome  { get; set; }
    
    public bool Status { get; set; }
    
    public string Destaque { get; set; }
    public ICollection<Anuncio> Anuncio { get; set; }

    public Plano(Guid id, decimal qtdAnuncios, string nome, bool status, string destaque)
    {
        Id = id;
        QtdAnuncios = qtdAnuncios;
        Nome = nome;
        Status = status;
        Destaque = destaque;
    }
}