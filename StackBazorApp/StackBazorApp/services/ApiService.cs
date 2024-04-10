public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> ObtenerDatosDeApi()
    {
        // Realizar la llamada a la API aquí
        HttpResponseMessage response = await _httpClient.GetAsync("https://api.ejemplo.com/datos");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }
        else
        {
            return string.Empty;
        }
    }
}
