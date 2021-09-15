

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class UfEntity : BaseEntity
    {
        [Required]
        [MaxLength(2)]
        public string Sigla { get; set; }

        [Required]
        [MaxLength(45)]
        public string Nome { get; set; }

        // Relação de 1 - N => 1 UF contem N Municipios
        public IEnumerable<MunicipioEntity> Municipios { get; set; }
    }
}