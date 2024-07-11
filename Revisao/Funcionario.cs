using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Funcionario : Pessoa
    {
        private int matricula { get; set; }
        public string placaVeiculo { get; set; }

        public int ValorMatricula()
        {
            return matricula;
        }

        public bool verificarVeiculo(Automovel automovel)
        {
            if (placaVeiculo.Length==7)
            {
                Console.WriteLine("Placa tem 7 caracteres");
                return true;
            }else
            {
                Console.WriteLine("Placa não tem 7 caracteres");
                return false;
            }
            
        }
    }
}
