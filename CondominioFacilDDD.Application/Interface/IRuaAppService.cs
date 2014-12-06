using System.Collections.Generic;
using CondominioFacilDDD.Domain.Entities;

namespace CondominioFacilDDD.Application.Interface
{
    public interface IRuaAppService : IAppServiceBase<Rua>
    {
        IEnumerable<Rua> BuscarPorNome(string nome);
    }
}
