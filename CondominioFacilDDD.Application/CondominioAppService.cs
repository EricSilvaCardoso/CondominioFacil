using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CondominioFacilDDD.Application.Interface;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.Domain.Interfaces.Services;

namespace CondominioFacilDDD.Application
{
    public class CondominioAppService : AppServiceBase<Condominio>, ICondominioAppService
    {
        private readonly ICondominioService _condominioService;

        public CondominioAppService(ICondominioService condominioService)
            :base(condominioService)
        {
            _condominioService = condominioService;
        }

    }
}
