using System.Collections.Generic;
using CondominioFacilDDD.Domain.Entities;

namespace CondominioFacilDDD.Domain.Interfaces.Repositories
{
    public interface IRuaRepository : IRepositoryBase<Rua>
    {
        IEnumerable<Rua> BuscarPorNome(string nome);
    }
}
