using System.Net.Http.Json;
using BlazorWasmBrasilApiCep.Models;

namespace BlazorWasmBrasilApiCep.Services
{
    public class CepService
    {
        private readonly HttpClient _httpClient;

        public CepService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

       public async Task<Cep?> BuscarCepAsync(string cep)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<Cep>(
                 $"api/cep/v1/{cep}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}