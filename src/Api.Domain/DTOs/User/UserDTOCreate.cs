

using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.User
{
    public class UserDTOCreate
    {
        [Required(ErrorMessage = "Email é um campo obrigatório para o login")]
        [StringLength(60, ErrorMessage = "O campo Email pode conter no máximo 60 caractéres.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email é um campo obrigatório para o login")]
        [EmailAddress(ErrorMessage = "Email em formato inválido")]
        [StringLength(100, ErrorMessage = "O campo Email pode conter no máximo 100 caractéres.")]
        public string Email { get; set; }
    }
}