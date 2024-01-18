using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_e_Metodos
{
     class Membros{
        public static void Executar(){

            Pessoa sicriano = new Pessoa();
            sicriano.Nome = "Renato";
            sicriano.Idade = 21;

            // Console.WriteLine($"{sicriano.Nome} tem {sicriano.Idade} anos.");

            sicriano.ApresentarNoConsole(); // assim ele vai estar puxando as informações sem eu precisar estar abrindo o cw e digitando as variaveis 

            var fulano = new Pessoa();
            fulano.Nome = "Alex";
            fulano.Idade = 22;

            var apresentacaoDoFulano = fulano.Apresentar(); // assim ele vai estar puxando as informações sem eu precisar estar abrindo o cw e digitando as variaveis  porém eu insiro o apelido que eu quero para ele puxar
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
