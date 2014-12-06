using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CondominioFacilDDD.MVC.ViewModels
{
    public class PropietarioViewModel
    {
        [Key]
        public int PropietarioId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Sobre Nome")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo Telefone")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [RegularExpression(@"^\d{4}[-]{1}\d{4}$", ErrorMessage = "Telefone inválido. Informe ####-####.")]
        public string Telefone { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<CondominioViewModel> Condominios { get; set; }
    }
}