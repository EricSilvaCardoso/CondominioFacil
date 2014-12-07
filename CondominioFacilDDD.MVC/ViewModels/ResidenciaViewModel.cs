using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CondominioFacilDDD.MVC.ViewModels
{
    public class ResidenciaViewModel
    {
        [Key]
        public int ResidenciaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo numero")]
        [Range(1, Int16.MaxValue, ErrorMessage = "O numero deve ser maior que 1")]
        [DisplayName("Numero da Residência")]
        public string NResidencia { get; set; }

        [DisplayName("Nome da Rua")]
        public int RuaId { get; set; }

        public virtual RuaViewModel Rua { get; set; }
    }
}