
using System.Net.Http.Json;
using WeatherForecast.Models.ApiModels;

namespace WeatherForecast.Services
{
    public class WeatherApiService
    {
        private readonly HttpClient _httpClient;

        public WeatherApiService() 
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Constants.BASE_URL);
        }

        public async Task<WeatherApiResponse> GetWeatherInfo(string lat, string lon)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return null;

            var response = await _httpClient.GetFromJsonAsync<WeatherApiResponse>($"data/2.5/forecast?lat={lat}&lon={lon}&units=metric&appid={Constants.API_KEY}");

            return response;
        }

        public async Task<WeatherApiResponse> GetWeatherInfoByCity(string cityName)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return null;

            var response = await _httpClient.GetFromJsonAsync<WeatherApiResponse>($"data/2.5/forecast?q={cityName}&units=metric&appid={Constants.API_KEY}");

            return response;
        }
    }
}
