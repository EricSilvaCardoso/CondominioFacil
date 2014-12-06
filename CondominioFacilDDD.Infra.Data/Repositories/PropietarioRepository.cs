using System.Collections.Generic;
using System.Linq;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.Domain.Interfaces.Repositories;

namespace CondominioFacilDDD.Infra.Data.Repositories
{
    public class PropietarioRepository : RepositoryBase<Propietario>, IPropietarioRepository
    {
        public IEnumerable<Propietario> BuscarPorNome(string nome)
        {
            return Db.Propietarios.Where(p => p.Nome == nome);
        }
    }
}
