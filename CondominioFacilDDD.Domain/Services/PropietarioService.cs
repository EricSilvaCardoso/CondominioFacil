using System.Collections.Generic;
using System.Linq;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.Domain.Interfaces.Repositories;
using CondominioFacilDDD.Domain.Interfaces.Services;

namespace CondominioFacilDDD.Domain.Services
{
    public class PropietarioService : ServiceBase<Propietario>, IPropietarioService
    {
        private readonly IPropietarioRepository _propietarioRepository;

        public PropietarioService(IPropietarioRepository propietarioRepository)
            :base(propietarioRepository)
        {
            _propietarioRepository = propietarioRepository;
        }

        public IEnumerable<Propietario> ObterPropietariosEspeciais(IEnumerable<Propietario> propietarios)
        {
            return propietarios.Where(c => c.PropietarioEspecial(c));
        }

        public IEnumerable<Propietario> BuscarPorNome(string nome)
        {
            return _propietarioRepository.BuscarPorNome(nome);
        }
    }
}
