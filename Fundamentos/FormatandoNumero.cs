using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class FormatandoNumero{
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            // Valor.ToString vai repassar o valor que está em double porém se você inserir ("F1") ele vai executar somente uma casa decimal após a virgula
            Console.WriteLine(valor.ToString("C"));
            // ("C") Vai estar repassando o valor monetario Ex R$ 15,18
            Console.WriteLine(valor.ToString("P"));
            // ("P") Valor de percentual multiplica o valor por 100 e vai repassar o valor de percentual
            Console.WriteLine(valor.ToString("#.##"));
            // ("#.##") vai repassar o valor com duas casas decimais

            /* CultureInfo Cultura = new CultureInfo("pt-BR")
             * Console.WriteLine(valor.ToString("C0", cultura));
             * você vai repassar uma nova cultura para o vs e ele vai estar repassando o valor para ex: R$ 15 pois o "C0" não leva casas decimais
             */
            /* CultureInfo Cultura = new CultureInfo("en-US")
            * Console.WriteLine(valor.ToString("C0", cultura));
            * você vai repassar uma nova cultura para o vs e ele vai estar repassando o valor o dolar
            */


        }
    }
}
