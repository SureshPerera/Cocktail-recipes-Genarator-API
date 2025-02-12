var baseAddress = "https://www.thecocktaildb.com/api/json/v1/1/";
var requistUri = "search.php?s=margarita";


Console.ReadLine();
public interface IApiDataReader
{
    public Task<string> Read(string baseAddress, string requistUri);
}
public class ApiDataReader : IApiDataReader
{
    public async Task<string>Read(string baseAddress, string requistUri)
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(baseAddress);
        HttpResponseMessage responce = await client.GetAsync(requistUri);
        responce.EnsureSuccessStatusCode();
        var json =await responce.Content.ReadAsStringAsync();
        return json;
    }
}