using System.Collections.Generic;
using System.Linq;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.Domain.Interfaces.Repositories;

namespace CondominioFacilDDD.Infra.Data.Repositories
{
    public class RuaRepository : RepositoryBase<Rua>, IRuaRepository
    {
        public IEnumerable<Rua> BuscarPorNome(string nome)
        {
            return Db.Ruas.Where(p => p.Nome == nome);
        }
    }
}
