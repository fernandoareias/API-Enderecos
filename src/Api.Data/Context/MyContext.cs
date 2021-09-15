


using Api.Data.Mapping;
using Api.Data.Seeds;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{

    public class MyContext : DbContext
    {

        public DbSet<UserEntity> User { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seta as settings das props
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);

            modelBuilder.Entity<UfEntity>(new UfMap().Configure);
            modelBuilder.Entity<MunicipioEntity>(new MunicipioMap().Configure);
            modelBuilder.Entity<CepEntity>(new CepMap().Configure);

            // Injeta um usuario default no banco
            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity()
                {
                    Id = System.Guid.NewGuid(),
                    Name = "Admin",
                    Email = "admin@admin.com.br",
                    CreateAt = System.DateTime.UtcNow,
                    UpdateAT = System.DateTime.UtcNow
                }
            );
            // Injeta a lista de UFs no banco
            UfSeeds.Ufs(modelBuilder);
        }
    }
}