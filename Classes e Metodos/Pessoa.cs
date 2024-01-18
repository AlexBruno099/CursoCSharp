using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_e_Metodos
{
    internal class Pessoa{
        
        public string Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format(
                $"Olá! Me chamo {Nome} e tenho {Idade} anos");
                }
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}
