using System.Collections.Generic;
using CondominioFacilDDD.Application.Interface;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.Domain.Interfaces.Services;

namespace CondominioFacilDDD.Application
{
    public class RuaAppService : AppServiceBase<Rua>, IRuaAppService
    {
        private readonly IRuaService _ruaAppService;

        public RuaAppService(IRuaService ruaService)
            :base(ruaService)
        {
            _ruaAppService = ruaService;
        }

        public IEnumerable<Rua> BuscarPorNome(string nome)
        {
            return _ruaAppService.BuscarPorNome(nome);
        }
    }
}
