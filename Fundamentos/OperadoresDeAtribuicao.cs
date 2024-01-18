using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class OperadoresDeAtribuicao{
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7; // substitui o primeiro valor 
            num1 += 10; // num1 = num1 + 10  
            num1 -= 3;  // num1 = num1 - 3  
            num1 *= 5; // num1 = num1 * 5 
            num1 /= 2; // num1 = num1 / 2  

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1;
            b++; // b = b - 1;

            Console.WriteLine($"{a} {b}");

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);
            //basicamente o dynamic compartilhado ex "d = c" os dois irão estar se compartilhando então quando você executa ao inves de sair o nome do joao vai apresentar maria
        }
    }
}
