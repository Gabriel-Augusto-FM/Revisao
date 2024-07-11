using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Pessoa
    {
        public string nome { get; set;}

        public bool Contatar()
        {
            Console.WriteLine("Usuário Contatado com sucesso");
            return true;
        }
    }
}
