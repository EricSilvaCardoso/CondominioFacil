using System;
using AutoMapper;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.MVC.ViewModels;

namespace CondominioFacilDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile :Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {   
            Mapper.CreateMap<Rua, RuaViewModel>();
            Mapper.CreateMap<Residencia, ResidenciaViewModel>();
            Mapper.CreateMap<Propietario, PropietarioViewModel>();
            Mapper.CreateMap<Condominio, CondominioViewModel>();
        }
    }
}