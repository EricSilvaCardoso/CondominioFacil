using System.Collections.Generic;
using CondominioFacilDDD.Domain.Entities;

namespace CondominioFacilDDD.Domain.Interfaces.Services
{
    public interface IPropietarioService : IServiceBase<Propietario>
    {
        IEnumerable<Propietario> ObterPropietariosEspeciais(IEnumerable<Propietario> propietarios);
        IEnumerable<Propietario> BuscarPorNome(string nome);
    }
}
