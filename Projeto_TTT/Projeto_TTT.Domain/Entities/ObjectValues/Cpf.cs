using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TTT.Domain.Entities.ObjectValues
{
    public class Cpf
    {
        private string cpfValor = string.Empty;

        public string CpfValor { get => cpfValor; set => cpfValor = ValidarCpf(value); }

        //Entrada 999.999.999-00 -> 99999999900 (válida)
        private string ValidarCpf(string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            value = value.Trim();
            value = value.Replace(".", "").Replace("-", "");
            
            return string.Empty;
        }
    }
}
