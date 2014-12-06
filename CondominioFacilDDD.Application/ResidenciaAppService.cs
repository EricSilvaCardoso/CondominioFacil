using CondominioFacilDDD.Application.Interface;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.Domain.Interfaces.Services;

namespace CondominioFacilDDD.Application
{
    public class ResidenciaAppService : AppServiceBase<Residencia>, IResidenciaAppService
    {
        private readonly IResidenciaService _residenciaService;

        public ResidenciaAppService(IResidenciaService residenciaService)
            :base(residenciaService)
        {
            _residenciaService = residenciaService;
        }
    
    }
}
