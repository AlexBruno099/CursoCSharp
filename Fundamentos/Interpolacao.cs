using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class interpolacao
    {
        public static void Executar()
        {
            string nome = "notebook gamer";
            string marca = "Dell";
            double preco = 10.50;

            Console.WriteLine("O " + nome, "da Marca " + marca, "Fica " + preco);
            Console.WriteLine("O  {0} Da Marca  {1} Fica  {2}", nome,marca,preco);
        }
    }
}