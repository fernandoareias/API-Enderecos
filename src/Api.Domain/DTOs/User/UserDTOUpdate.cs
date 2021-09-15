

using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.User
{
    public class UserDTOUpdate
    {
        [Required(ErrorMessage = "Id é um campo obrigatório para o login")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name é um campo obrigatório para o login")]
        [StringLength(60, ErrorMessage = "O campo Name pode conter no máximo 60 caractéres.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email é um campo obrigatório para o login")]
        [EmailAddress(ErrorMessage = "Email em formato inválido")]
        [StringLength(100, ErrorMessage = "O campo Email pode conter no máximo 100 caractéres.")]
        public string Email { get; set; }
    }
}