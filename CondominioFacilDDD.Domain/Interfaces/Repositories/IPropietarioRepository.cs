using System.Collections.Generic;
using CondominioFacilDDD.Domain.Entities;

namespace CondominioFacilDDD.Domain.Interfaces.Repositories
{
    public interface IPropietarioRepository : IRepositoryBase<Propietario>
    {
        IEnumerable<Propietario> BuscarPorNome(string nome);
        
    }
}
