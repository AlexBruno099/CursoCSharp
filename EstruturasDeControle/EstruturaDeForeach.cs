using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
     class EstruturaDeForeach{
        public static void Executar() {
            var palavra = "Opa!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }
            var alunos = new string[] { "ana", "Bia", "Carlos" };
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            // ForEach te permite pegar cada item dessa lista e fazer algo específico com ele, um de cada vez, até que todos tenham sido processados.
        }
    }
}
