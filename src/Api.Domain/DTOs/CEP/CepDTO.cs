

using System;
using Api.Domain.DTOs.Municipio;

namespace Api.Domain.DTOs.CEP
{
    public class CepDTO
    {
        public Guid Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }

        public string Numeroi { get; set; }
        public Guid MunicipioId { get; set; }
        public MunicipioDTO Municipio { get; set; }
    }
}