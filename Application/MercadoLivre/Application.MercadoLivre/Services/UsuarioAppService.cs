using System.Net.Http.Headers;
using System.Text.Json;
using Application.MercadoLivre.Interfaces;
using Application.MercadoLivre.ViewModels;
using AutoMapper;
using Domain.MercadoLivre;
using Domain.MercadoLivre.Interfaces;

namespace Application.MercadoLivre.Services;

public class UsuarioAppService : IUsuarioAppService
{
    public readonly HttpClient _httpClient;
    public readonly IUsuarioRepository _usuarioRepository;
    public readonly IMapper _mapper;
    
    //Todo remover após criar campos no banco
    private string _ClientId = "8441971776010095";
    private string _ClientSecret = "7vxqhSAWAYIgPXAu9zRTVeKA8UJgdxBK";
    private string _RedirectUri = "";
    
    public UsuarioAppService(HttpClient httpClient, IUsuarioRepository usuarioRepository, IMapper mapper)
    {
        _httpClient = httpClient;
        _usuarioRepository = usuarioRepository;
        _mapper = mapper;
    }
    public MercadoLivreResponseViewModel? GetTokenOAuth(string code, string state)
    {
        if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(state))
            throw new Exception("Não foi possível obter os dados vindos do mercado livre");

        var body = GerarBodyMercadoLivre(code, _ClientId, _ClientSecret, _RedirectUri);
        
        var action = "/oauth/token";

        _httpClient.BaseAddress = new Uri("https://api.mercadolibre.com");
        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        HttpResponseMessage response = _httpClient.PostAsync(action, new FormUrlEncodedContent(body)).Result;
        response.EnsureSuccessStatusCode();
        
        if (!response.IsSuccessStatusCode)
            return null;
        
        var result = response.Content.ReadAsStringAsync().Result;
        
        if (string.IsNullOrEmpty(null))
            throw new Exception("Não foi possível obter o resultado da request ao mercado livre");
        
        Console.WriteLine(result);
        var mercadoLivreResponse = JsonSerializer.Deserialize<MercadoLivreResponseViewModel>(result);

        var usuario = _mapper.Map<UsuarioMercadoLivre>(mercadoLivreResponse);
        _usuarioRepository.AddUser(usuario);
        
        return mercadoLivreResponse;
    }

    public Dictionary<string, string> GerarBodyMercadoLivre(string code, string clientId, string clientSecret,
        string redirectURI)

    {
        var body = new Dictionary<string, string>
        {
            {"grant_type", "authorization_code"},
            {"client_id", clientId},
            {"client_secret", clientSecret},
            {"code", code},
            {"redirect_uri", redirectURI},
        };

        return body;
    }
}