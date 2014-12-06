using System;
using System.ComponentModel.DataAnnotations;

namespace CondominioFacilDDD.MVC.ViewModels
{
    public class CondominioViewModel
    {
        [Key]
        public int CondominioId { get; set; }

        public int ResidenciaId { get; set; }

        public int MoradorId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public virtual ResidenciaViewModel Residencia { get; set; }

        public PropietarioViewModel Propietario { get; set; }
    }
}