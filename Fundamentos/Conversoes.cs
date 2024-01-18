using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class Conversoes{
        public static void Executar(){
            int inteiro = 10;
            double quebrado = inteiro;
            // conversão de valor inteiro para um valor quebrado, esse metodo da certo pois o double armazena uma maior númeração que o int 
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota;
            // como o int seria somente números inteiros você não consegue simplesmente estar convertendo o numero quebrado para o int você precisa expecificar que quer que o numero quebrado vire um numero inteiro
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadestring = Console.ReadLine();

            int idadeInteiro = int.Parse(idadestring);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadestring);
            Console.WriteLine("Resultado {0}", idadeInteiro);

            Console.WriteLine("Digite um Número");
            string palavra = Console.ReadLine();
          //  int numero;
            int.TryParse(palavra, out int numero);
            Console.WriteLine("resultado {0}", numero);
            // esse codigo, se a caso você inserir algum valor ou alguma palavra ao inves de ele retornar erro ele vai retornar o valor 0



        }
    }
}
