using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_e_Metodos
{
    internal class ParametroNomeado{
        public static void Formatar(int dia, int mes, int ano){
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }
        public static void Executar(){
            Formatar(mes: 1, dia: 6, ano: 1996);

            // sempre melhor escrever um pouco a mais e realizar um código que consigam entender 
            // do que fazer um codigo mais curto sem nomeado e sem entender nada

        }
    }
}
