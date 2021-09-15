using System;
using System.ComponentModel.DataAnnotations;
using Api.Domain.DTOs.Municipio;

namespace Api.Domain.DTOs.CEP
{
    public class CepDTOCreateResult
    {

        public Guid Id { get; set; }
        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public Guid MunicipioId { get; set; }
    }
}