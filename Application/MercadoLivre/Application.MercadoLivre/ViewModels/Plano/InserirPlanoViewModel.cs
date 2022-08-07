using System.ComponentModel.DataAnnotations;

namespace Application.MercadoLivre.ViewModels.Plano;

public class InserirPlanoViewModel
{
    public int QtdAnuncios { get; set; }
    
    [Required(ErrorMessage = "O nome é obrigatório.")]
    public string Nome { get; set; }

    public string Destaque { get; set; }
    
    public bool Status { get; set; } = true;
    
}