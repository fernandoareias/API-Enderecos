

using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email é um campo obrigatório para o login")]
        [EmailAddress(ErrorMessage = "Email em formato inválido")]
        [StringLength(100, ErrorMessage = "O campo Email pode conter no máximo 100 caractéres.")]
        public string Email { get; set; }
    }
}