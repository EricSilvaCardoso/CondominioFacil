using System.Collections.Generic;
using CondominioFacilDDD.Application.Interface;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.Domain.Interfaces.Services;

namespace CondominioFacilDDD.Application
{
    public class PropietarioAppService : AppServiceBase<Propietario>, IPropietarioAppService
    {
        private readonly IPropietarioService _propietarioAppService;

        public PropietarioAppService(IPropietarioService propietarioService)
            :base(propietarioService)
        {
            _propietarioAppService = propietarioService;

        }


        public IEnumerable<Propietario> ObterPropietariosEspeciais()
        {
            return _propietarioAppService.ObterPropietariosEspeciais(_propietarioAppService.GetAll());
        }

        public IEnumerable<Propietario> BuscarPorNome(string nome)
        {
            return _propietarioAppService.BuscarPorNome(nome);
        }
    }
}
