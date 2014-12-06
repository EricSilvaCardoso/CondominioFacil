using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CondominioFacilDDD.MVC.ViewModels
{
    public class RuaViewModel
    {
        [Key]
        public int RuaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        public virtual IEnumerable<ResidenciaViewModel> Residencias { get; set; }
    }
}