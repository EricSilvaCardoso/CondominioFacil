using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.Domain.Interfaces.Repositories;
using CondominioFacilDDD.Domain.Interfaces.Services;

namespace CondominioFacilDDD.Domain.Services
{
    public class ResidenciaService : ServiceBase<Residencia>, IResidenciaService
    {
        private readonly IResidenciaRepository _residenciaRepository;

        public ResidenciaService(IResidenciaRepository residenciaRepository)
            : base(residenciaRepository)
        {
            _residenciaRepository = residenciaRepository;
        }
    }
}
