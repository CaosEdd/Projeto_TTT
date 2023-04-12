using Projeto_TTT.Domain.Entities.AggregateRoots;
using Projeto_TTT.Domain.Entities.ObjectValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TTT.Domain.Entities.Aggregates
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public Cep Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

    }
}
