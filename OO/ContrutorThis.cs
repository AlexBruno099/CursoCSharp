using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }
    public class Cachorro : Animal
    {
        double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }
       public Cachorro (string nome, double altura): this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura!";
        }
    }
     class ContrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("spike");
            var mike = new Cachorro("Mike", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(mike);
        }
    }
}
