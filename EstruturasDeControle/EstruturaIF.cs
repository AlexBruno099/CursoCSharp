using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIF
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento? (S/N): ");
            entrada = Console.ReadLine();

            if( entrada == "S" || entrada == "s");
            /* pode ser feito de outras maneiras
             * bomComportamento = entrada == "S" || entrada == "s";
             * bomComportamento = entrada.ToLower() == "s"; desta maneira inserindo tanto S ou s ele vai entender que é S e vai repassar o resultado
             */
            bomComportamento = true;

            if (nota >= 9.0 && bomComportamento) // se você informar o ; nessa parte do codigo ele vai cortar esta parte e mesmo o aluno não tendo bom comportamento e nem nota vai aparecer no quadro de honra pois 
                                                 // cortou esta parte do codigo e o comando console.writeline vai aparecer do mesmo jeito
            {
                Console.WriteLine("Quadro de Honra!");
            }

        }
    }
}