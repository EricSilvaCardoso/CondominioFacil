using System.Collections;
using System.Collections.Generic;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.Domain.Interfaces.Repositories;
using CondominioFacilDDD.Domain.Interfaces.Services;

namespace CondominioFacilDDD.Domain.Services
{
    public class RuaService : ServiceBase<Rua>, IRuaService
    {
        private readonly IRuaRepository _ruaRepository;

        public RuaService(IRuaRepository ruaRepository)
            :base(ruaRepository)
        {
            _ruaRepository = ruaRepository;
        }

        public IEnumerable<Rua> BuscarPorNome(string nome)
        {
            return _ruaRepository.BuscarPorNome(nome);
        }
    }
}
