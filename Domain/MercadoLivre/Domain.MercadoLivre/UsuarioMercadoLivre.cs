namespace Domain.MercadoLivre;

public class UsuarioMercadoLivre 
{
    public Guid Id { get; set; }
    public string Token { get; set; }

    public decimal DataExpiracao { get; set; }
    
    public string RefreshToken { get; set; }
    public string Client_Secret { get; set; }
    public string Client_Id { get; set; }
}