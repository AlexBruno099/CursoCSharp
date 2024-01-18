using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_e_Metodos
{
    internal class Params{
        public static void Recepcionar(params string[] pessoas) // esse parametro ele armazena todos os outros
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {}", pessoa);
            }
        }
        public static void Executar(){
            Recepcionar("Pedro", "Manu", "Roger", "Ana", "Bia"); // por conta deste parametro ele puxa o cw para todas essas "Pessoas"
        }
    }
}
