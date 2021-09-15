using System;
using System.ComponentModel.DataAnnotations;
using Api.Domain.DTOs.Municipio;

namespace Api.Domain.DTOs.CEP
{
    public class CepDTOCreate
    {
        [Required(ErrorMessage = "CEP é um campo obrigatório.")]
        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }
        [Required(ErrorMessage = "Municipio é um campo obrigatório.")]
        public Guid MunicipioId { get; set; }
    }
}