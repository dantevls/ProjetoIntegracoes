namespace Application.MercadoLivre.ViewModels;

public class MercadoLivreViewModel
{
    public string Code { get; set; }
    
    public string Redirect_uri { get; set; }
    
    public string Grant_type { get; set; }
    
    public string Client_id { get; set; }
    
    public string Client_secret { get; set; }

    public MercadoLivreViewModel( string grant_type, string client_id , string client_secret ,string code, string redirect_uri)
    {
        Code = code;
        Redirect_uri = redirect_uri;
        Grant_type = grant_type;
        Client_id = client_id;
        Client_secret = client_secret;
    }
}