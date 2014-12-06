using AutoMapper;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.MVC.ViewModels;

namespace CondominioFacilDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<RuaViewModel, Rua>();
            Mapper.CreateMap<ResidenciaViewModel, Residencia>();
            Mapper.CreateMap<PropietarioViewModel, Propietario>();
            Mapper.CreateMap<CondominioViewModel, Condominio>();
        }
    }
}