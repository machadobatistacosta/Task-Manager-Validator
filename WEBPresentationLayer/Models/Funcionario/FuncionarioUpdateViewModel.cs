﻿using Entities;
using Entities.Enums;
using System.ComponentModel.DataAnnotations;


namespace WEBPresentationLayer.Models.Funcionario
{
    public class FuncionarioUpdateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome deve ser informado.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Nome deve conter entre 3 e 30 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sobrenome deve ser informado!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Sobrenome deve conter entre 3 e 30 caracteres.")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Email deve ser informado.")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Data Nascimento deve ser informada")]
        [DataType(DataType.Date)]
        [Display(Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Genero deve ser informado.")]
        public Genero Genero { get; set; }

        [Required(ErrorMessage = "Informar nivel de acesso")]
        [Display(Name = "Nivel De Acesso")]
        public NivelDeAcesso NivelDeAcesso { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

    }
}
