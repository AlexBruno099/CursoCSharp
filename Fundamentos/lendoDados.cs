using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class lendoDados{
        public static void Executar(){
            // vai estar lendo os dados inseridos no console.write e no final ele vai lhe dar o nome a idade e o seu salario 
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            // o comando  Console.ReadLine() vai estar lendo a informação inserida e vai estar armazenando na "string nome" e repassando o resultado no Console.WriteLine

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            // o comando  Console.ReadLine() vai estar lendo a informação inserida e vai estar armazenando na "int idade" e repassando o resultado no Console.WriteLine

            Console.Write("Qual é o seu salario? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // o comando  Console.ReadLine() vai estar lendo a informação inserida e vai estar armazenando na "double salario" e repassando o resultado no Console.WriteLine
            /*
             * CultureInfo.InvariantCulture sem esse comando vai ler oque está configurado na maquina normalmente vai ser , ex: 100,00
             * com esse comando ele vai estar lendo como . ex: 100.00 
             */

            Console.WriteLine($"{nome} {idade} R${salario}");
            // aqui vai estar interpolando todos os resultados que foram repassados no console
            
        }
    }
}
