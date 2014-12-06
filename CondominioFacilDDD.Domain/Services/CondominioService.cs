using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.Domain.Interfaces.Repositories;
using CondominioFacilDDD.Domain.Interfaces.Services;

namespace CondominioFacilDDD.Domain.Services
{
    public class CondominioService : ServiceBase<Condominio>, ICondominioService
    {
        private readonly ICondominioRepository _condominioRepository;

        public CondominioService(ICondominioRepository condominioRepository)
            : base(condominioRepository)
        {
            _condominioRepository = condominioRepository;
        }

    }
}
