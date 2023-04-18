using Microsoft.AspNetCore.Identity;
using Projeto_TTT.Domain.Entities.Aggregates;
using Projeto_TTT.Domain.Entities.ObjectValues;
using Projeto_TTT.Domain.Entities.ObjectValues.Enumarators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TTT.Domain.Entities.AggregateRoots
{
    public class Usuario : IdentityUser
    {
        public int UsuarioId { get; set; }
        public string NomeCompleto { get; set; }
        public string Apelido { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public Genero Genero { get; set; }
        public Cpf Cpf { get; set;}
        public Orixa OrixaPrincipal { get; set; }      
        public Orixa OrixaSecundario { get; set;}
        public DateTime DataEntrada { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public int AtualizadoPor { get; set; }
        public int FamiliaId { get; set; }
        public bool ResponsavelFamilia { get; set; }
        public bool Disponivel { get; set; }
        public Preferencia Preferencia { get; set; }

        public int EnderecoId { get; set; }
        public Endereco Endereco{ get; set; }

    }
}
