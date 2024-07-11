using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Funcionario:Pessoa
    {
        public int matricula { get; set; }
        private string placaVeiculo { get; set; }

        public bool verificarVeiculo(Automovel automovel)
        {
            return true;
        }
    }
}
