using System;
using System.ComponentModel.DataAnnotations;
using Api.Domain.DTOs.UF;

namespace Api.Domain.DTOs.Municipio
{
    public class MunicipioDTOCreate
    {
        [Required(ErrorMessage = "Nome do municipio é obrigatório.")]
        [StringLength(60, ErrorMessage = "Nome do município deve conter no máximo {1} caractéres.")]
        public string Nome { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Código inválido.")]
        public int CodIBGE { get; set; }

        [Required(ErrorMessage = "Código da UF é obrigatório.")]
        public Guid UfId { get; set; }
    }
}