using System.Collections.Generic;
using CondominioFacilDDD.Domain.Entities;

namespace CondominioFacilDDD.Domain.Interfaces.Services
{
    public interface IRuaService : IServiceBase<Rua>
    {
        IEnumerable<Rua> BuscarPorNome(string nome);
    }
}
