using BlazorAuthenticationJwt.Auth.DTOs;
using Microsoft.AspNetCore.Identity.Data;
using Newtonsoft.Json;
using System.Net.Http;

namespace BlazorAuthenticationJwt.Auth.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Test()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("api/Account/test");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<HttpResponseMessage> Login(AuthenticationRequestDTO request)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Account/Login", request);
            return result;
            
        }

    }
}
