using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CondominioFacilDDD.MVC.ViewModels
{
    public class CondominioViewModel
    {
        [Key]
        public int CondominioId { get; set; }

        [DisplayName("Numero da Residência")]
        public int ResidenciaId { get; set; }

        [DisplayName("Nome do Propietário")]
        public int PropietarioId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public virtual ResidenciaViewModel Residencia { get; set; }

        public PropietarioViewModel Propietario { get; set; }
    }
}