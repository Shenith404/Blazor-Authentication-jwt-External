using System.ComponentModel.DataAnnotations;

namespace BlazorAuthenticationJwt.Auth.DTOs
{
    public class AuthenticationRequestDTO
    {


        public string UserName { get; set; } = "";


        public string Password { get; set; } = "";


    }
}
