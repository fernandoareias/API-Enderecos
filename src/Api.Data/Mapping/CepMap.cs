



using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class CepMap : IEntityTypeConfiguration<CepEntity>
    {
        public void Configure(EntityTypeBuilder<CepEntity> builder)
        {
            builder.ToTable("Cep");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Cep).IsUnique();
            builder.HasOne(x => x.Municipio).WithMany(m => m.Ceps);
        }
    }

}