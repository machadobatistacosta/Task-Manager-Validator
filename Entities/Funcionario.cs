﻿using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities
{
    public class Funcionario : PessoaFisica
    {
        public Funcionario()
        {
            this.Endereco = new Endereco();
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
        public Genero Genero { get; set; }
        public NivelDeAcesso NivelDeAcesso { get; set; }
        public bool IsAtivo { get; set; }
        public string? RefreshToken { get; set; }
        [JsonIgnore]
        public string Senha { get; set; }
    }
}
