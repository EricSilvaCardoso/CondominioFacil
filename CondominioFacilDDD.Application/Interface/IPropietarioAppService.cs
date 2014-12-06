
using System.Collections.Generic;
using CondominioFacilDDD.Domain.Entities;

namespace CondominioFacilDDD.Application.Interface
{
    public interface IPropietarioAppService : IAppServiceBase<Propietario>
    {
        IEnumerable<Propietario> ObterPropietariosEspeciais();
        IEnumerable<Propietario> BuscarPorNome(string nome);
    }
}
