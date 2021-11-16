using System.Net.Http.Json;
public class ViaCepConsumidor
{
    public const string URI_BASE = "https://viacep.com.br/ws";
    private static readonly HttpClient client = new HttpClient();
    public static async Task<HttpResponseMessage> Consultar(string cep)
    {
        var uri = $"{URI_BASE}/{cep}/json/";
        var resposta = await client.GetAsync(uri);
        return resposta;
    }

    public static Task<string> ConsultarV2(string cep)
    {
        var uri = $"{URI_BASE}/{cep}/json/";
        return client.GetStringAsync(uri);
    }

    public static Task<ViaCep?> ConsultarV3(string cep)
    {
        var uri = $"{URI_BASE}/{cep}/json/";
        return client.GetFromJsonAsync<ViaCep>(uri);
    }
}

public class ViaCep
{
    public string? Cep { get; set; }
    public string? Logradouro { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string? Localidade { get; set; }
    public string? Uf { get; set; }
}