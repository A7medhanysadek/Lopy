using Azure.Core;
using System.Diagnostics;

namespace LopyBackendWebApp.Services
{
    public class AmadeusApiClient
    {
        private static AmadeusApiClient _instance;//c
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        private AmadeusApiClient()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://api.amadeus.com/v2/");
            _apiKey = "API_KEY";
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
        }

        public static AmadeusApiClient GetClient()//getclass
        {
            //if (_instance == null)
            //    _instance = new AmadeusApiClient();
            //return _instance;
            return _instance ??= new AmadeusApiClient();
        }

        public async Task<string> GetFlightsAsync(string origin, string destination)
        {
            var response = await _httpClient.GetAsync($"shopping/flight-offers?origin={origin}&destination={destination}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
