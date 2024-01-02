using ConsumindoApi.DadosDoCep;
using System.Text.Json;

string resultado;
Console.Write("Digite o CEP para conhecer o endereço: ");
string cep = Console.ReadLine()!;
string url = $"https://viacep.com.br/ws/{cep}/json/";

using (HttpClient client = new HttpClient())
{
    try
    {
        resultado = await client.GetStringAsync(url);
        var dadosDoCep = JsonSerializer.Deserialize<Dados>(resultado);
        dadosDoCep.ExibirDadosDoCep();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    }

}

