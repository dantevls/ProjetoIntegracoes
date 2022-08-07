using System.Runtime.Serialization;

namespace Application.MercadoLivre.ViewModels;

public class MercadoLivreResponseViewModel
{
    [DataMember(Name = "access_token")]
    public string Access_Token { get; set; }
    
    [DataMember(Name = "expires_in")]
    public decimal Expires_In { get; set; }
    
    [DataMember(Name = "scope")]
    public string Scope { get; set; }
    
    [DataMember(Name = "user_id")]
    public decimal User_Id { get; set; }
    
    [DataMember(Name = "refresh_token")]
    public string Refresh_Token { get; set; }
}