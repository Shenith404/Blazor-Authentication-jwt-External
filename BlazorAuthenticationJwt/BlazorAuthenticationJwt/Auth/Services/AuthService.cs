using Microsoft.AspNetCore.Identity.Data;

namespace BlazorAuthenticationJwt.Auth.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
     /*   public async Task<AuthResponse?> Login(AuthRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("auth/login", request);
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<AuthResponse>(content);
            }
            else
            {
                return null;
            }
        }*/
     
    }
}
