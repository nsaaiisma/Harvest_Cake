using HarvestAdminn.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace HarvestAdminn.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public AuthService(HttpClient httpClient,
                           IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<LoginResponse?> Login(LoginModel model)
        {
            var url = $"{_configuration["ApiSettings:BaseUrl"]}/auth/login";

            var json = JsonConvert.SerializeObject(model);

            Console.WriteLine("========== JSON ==========");
            Console.WriteLine(json);

            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json");

            var response = await _httpClient.PostAsync(url, content);

            var responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine("========== RESPONSE ==========");
            Console.WriteLine(responseBody);

            if (!response.IsSuccessStatusCode)
                return null;

            return JsonConvert.DeserializeObject<LoginResponse>(responseBody);
        }
    }
}