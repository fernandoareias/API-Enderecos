


using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class CepImplementation : BaseRepository<CepEntity>, ICepRepository
    {
        private DbSet<CepEntity> _datase;

        public CepImplementation(MyContext context) : base(context)
        {
            _datase = context.Set<CepEntity>();
        }

        public async Task<CepEntity> SelectAsync(string cep)
        {
            return await _datase.Include(c => c.Municipio).ThenInclude(u => u.Uf).FirstOrDefaultAsync(x => x.Cep.Equals(cep));
        }
    }
}