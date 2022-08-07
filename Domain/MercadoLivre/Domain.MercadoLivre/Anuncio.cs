using Domain.Util;

namespace Domain.MercadoLivre;

public class Anuncio : BaseEntity<Anuncio>
{
    public Guid UsuarioId { get; set; }
    public UsuarioMercadoLivre Usuario { get; set; }
    
    public Plano Plano { get; set; }
    public Guid PlanoId { get; set; }
    
    public SistemaExterno SistemaExterno { get; set; }
    
    public Guid SistemaExternoId { get; set; }
    
    public string Descricao { get; set; }
    
    public string Titulo { get; set; }
    
    public decimal Preco { get; set; }
    
    public string TipoProduto { get; set; }
    
}