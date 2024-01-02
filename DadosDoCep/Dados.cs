using System.Text.Json.Serialization;
namespace ConsumindoApi.DadosDoCep;

internal class Dados
{
    [JsonPropertyName("logradouro")]
    public string Logradouro { get; set; }

    [JsonPropertyName("bairro")]
    public string Bairro { get; set; }

    [JsonPropertyName("localidade")]
    public string Cidade { get; set; }

    [JsonPropertyName("uf")]
    public string Estado { get; set; }

    public void ExibirDadosDoCep()
    {
        Console.WriteLine($"Este CEP refere-se ao logradouro {Logradouro}," +
            $" no bairro {Bairro} da cidade de {Cidade}-{Estado}");
    }
}
